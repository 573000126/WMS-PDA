using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using CompactWebServer;
using MESWinCEClient.LightService.Dto;
using MESWinCEClient.LightService;

namespace MESWinCEClient
{
    public class LightController : BaseController
    {
        public static LightUtils LightUtils = new LightUtils();

        /// <summary>
        /// 测试网络链接
        /// </summary>
        /// <param name="req"></param>
        /// <param name="res"></param>
        [Route(HttpMethod.GET, "/api/ping")]
        public void Ping(HttpRequest req, HttpResponse res)
        {
            req.Server.RaiseLogEvent("info", string.Format("ping success"));
            res.SendJson("OK");
        }

        /// <summary>
        /// 亮灯塔服务
        /// </summary>
        /// <param name="req"></param>
        /// <param name="res"></param>
        [Route(HttpMethod.POST, "/api/HouseOrder")]
        public void HouseOrder(HttpRequest req, HttpResponse res)
        {
            req.Server.RaiseLogEvent("info", string.Format("HouseOrder success"));
            var houseLights = req.ParseJSON<List<HouseLight>>();

            LightMsg lightMsg = new LightMsg();
            try
            {
                if (houseLights.Count == 0)
                {
                    lightMsg.IsOK = false;
                    lightMsg.Msg = "灯塔控制失败:传入参数为空,请确保集合长度大于0";
                }
                else
                {
                    if (houseLights.FindAll(s => s.LightOrder != 1 && s.LightOrder != 0).Count > 0)
                    {
                        lightMsg.IsOK = false;
                        lightMsg.Msg = "灯塔控制失败:传入的亮灯模式出错,亮灯模式仅允许支持,0:灭灯,1:亮灯";
                    }
                    else
                    {
                        houseLights.ForEach(s => LightUtils.LightOrder.Enqueue(LightUtils.GetLightHouseOrder(s.MainBoardId, s.LightOrder, s.HouseLightSide)));
                        lightMsg.IsOK = true;
                        lightMsg.Msg = "灯塔控制命令添加成功";
                    }
                }

            }
            catch (Exception ee)
            {
                lightMsg.IsOK = false;
                lightMsg.Msg = ee.Message;
            }


            res.SendJson(lightMsg);
        }

        /// <summary>
        /// 整车亮灯
        /// </summary>
        /// <param name="req"></param>
        /// <param name="res"></param>
        [Route(HttpMethod.POST, "/api/AllLightOrder")]
        public void AllLightOrder(HttpRequest req, HttpResponse res)
        {
            req.Server.RaiseLogEvent("info", string.Format("AllLightOrder success"));
            var allLightOrders = req.ParseJSON<List<AllLight>>();

            LightMsg lightMsg = new LightMsg();
            try
            {
                if (allLightOrders.Count == 0)
                {
                    lightMsg.IsOK = false;
                    lightMsg.Msg = "整货架灯控制失败:传入参数为空,请确保集合长度大于0";
                    res.SendJson(lightMsg);
                    return;
                }
                if (allLightOrders.FindAll(s => s.LightOrder != 1 && s.LightOrder != 0).Count > 0)
                {
                    lightMsg.IsOK = false;
                    lightMsg.Msg = "整货架灯控制失败:传入的亮灯模式出错,亮灯模式仅允许支持,0:灭灯,1:亮灯";
                    res.SendJson(lightMsg);
                    return;
                }


                allLightOrders.ForEach(s => LightUtils.LightOrder.Enqueue(LightUtils.GetMoreLightsOrder(s.MainBoardId, s.LightOrder)));
                lightMsg.IsOK = true;
                lightMsg.Msg = "整货架灯控制灯命令添加成功";
                res.SendJson(lightMsg);
            }
            catch (Exception ee)
            {
                lightMsg.IsOK = false;
                lightMsg.Msg = ee.Message;
                res.SendJson(lightMsg);
            }
        }

        /// <summary>
        /// 多单灯服务
        /// </summary>
        /// <param name="req"></param>
        /// <param name="res"></param>
        [Route(HttpMethod.POST, "/api/LightOrder")]
        public void LightOrder(HttpRequest req, HttpResponse res)
        {
            req.Server.RaiseLogEvent("info", string.Format("LightOrder success"));
            var lights = req.ParseJSON<List<StorageLight>>();

            LightMsg lightMsg = new LightMsg();
            try
            {
                if (lights.FindAll(s => s.LightOrder != 1 && s.LightOrder != 0 && s.LightOrder != 2).Count > 0)
                {
                    lightMsg.IsOK = false;
                    lightMsg.Msg = "灯控制失败:传入的亮灯模式出错,亮灯模式仅允许支持,0:灭灯,1:亮灯,2:闪灯";
                    res.SendJson(lightMsg);
                    return;
                }

                if (lights.Count == 0)
                {
                    lightMsg.IsOK = false;
                    lightMsg.Msg = "灯控制失败:传入参数为空,请确保集合长度大于0";
                    res.SendJson(lightMsg);
                    return;
                }
                else if (lights.Count == 1)
                {
                    #region 单灯
                    LightUtils.LightOrder.Enqueue(LightUtils.GetOneLightOrder(lights[0].LightOrder, 10, 10, lights[0].ContinuedTime, lights[0].MainBoardId, lights[0].RackPositionId));
                    #endregion
                }
                else
                {
                    #region 多灯

                    //全部闪灯
                    List<StorageLight> lightsFlash = lights.FindAll(s => s.LightOrder == 2);
                    //全部亮灭灯
                    List<StorageLight> lightsNoFlash = lights.FindAll(s => s.LightOrder == 1 || s.LightOrder == 0);

                    Dictionary<int, Dictionary<int, int>> dic = new Dictionary<int, Dictionary<int, int>>();

                    foreach (var rack in lightsNoFlash.GroupBy(s => s.MainBoardId))
                    {
                        dic.Add(rack.Key, new Dictionary<int, int>());
                        foreach (var library in rack)
                        {
                            if (dic[rack.Key].Keys.Contains(library.RackPositionId))
                                dic[rack.Key][library.RackPositionId] = library.LightOrder;
                            else
                                dic[rack.Key].Add(library.RackPositionId, library.LightOrder);
                        }
                    }

                    foreach (var item in dic)
                    {
                        //添加多灯命令
                        LightUtils.LightOrder.Enqueue(LightUtils.GetMoreLightsOrder(item.Value, item.Key));
                    }
                    //添加闪灯命令
                    lightsFlash.ForEach(s => LightUtils.LightOrder.Enqueue(LightUtils.GetOneLightOrder(s.LightOrder, 10, 10, s.ContinuedTime, s.MainBoardId, s.RackPositionId)));
                    #endregion
                }
                lightMsg.IsOK = true;
                lightMsg.Msg = "灯命令添加成功";
                res.SendJson(lightMsg);
                return;
            }
            catch (Exception ee)
            {
                lightMsg.IsOK = false;
                lightMsg.Msg = ee.Message;
                res.SendJson(lightMsg);
                return;
            }
        }

    }
}
