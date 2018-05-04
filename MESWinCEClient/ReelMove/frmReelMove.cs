using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MESWinCEClient.ReelMove.Dtos;
using System.Linq;
using WinCEUtils;
using MESWinCEClient.LightService.Dto;

namespace MESWinCEClient.ReelMove
{
    public partial class frmReelMove : Form
    {
        ReelMoveMethodDto _reelMoveMethod { get; set; }

        string lightSer = WinCEUtils.IniFilesHelp.Ini.GetParam("LightSer", "http://localhost");

        bool IsLineReturn = false;
        bool lightIsRGB = false;
        public frmReelMove(ReelMoveMethodDto reelMoveMethod)
        {
            _reelMoveMethod = reelMoveMethod;
            // 获取货架类型

            var setting = HttpHelp.PostAbp<List<SettingValue>>("/api/services/app/Configuration/GetAppConfig", new List<string>() { "lightIsRGB" }).Result;

            if (setting.Count != 0 && setting[0].Value == "1")
            {
                lightIsRGB = true;
            }

            InitializeComponent();
            if (!_reelMoveMethod.AllocationTypes.Contains(AllocationType.OnSL))
            {
                this.panKW.Visible = false;
            }

            if (!_reelMoveMethod.AllocationTypes.Contains(AllocationType.Received))
            {
                panReceiveds.Visible = false;
                IsLineReturn = true;
            }

            if (_reelMoveMethod.AllocationTypes.Contains(AllocationType.UpByShelf))
            {
                labReel.Text = "库位标签";
            }

            txtQty.Text = "0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DateTime tm1 = DateTime.Now;

                StorageLocationDto storageLocationDto = new StorageLocationDto();
                if (panKW.Visible)
                {
                    try
                    {
                        storageLocationDto = HttpHelp.GetAbp<StorageLocationDto>("/api/services/app/StorageLocation/Get?Id=" + txtShlefLab.Text, null).Result;
                    }
                    catch (Exception ex)
                    {
                        WinCEUtils.FormHelp.SetTsLab(txtmag, "输入库位标签不合法" + ex.Message, new List<string>() { "Fail" }, Color.Red);
                    }
                }


                ReelMoveDto que = new ReelMoveDto() { ReturnReelQty = int.Parse(txtQty.Text), BarCode = txtBarCode.Text, IQCCheckId = cboIQCCheckId.Text, ExtendShelfLife = 0, IsContinuity = ckbIsContinuity.Checked, ShlefLab = txtShlefLab.Text, ReelMoveMethodId = _reelMoveMethod.Id, IsReturnReel = IsLineReturn };
                // 检查是否有退料
                if (_reelMoveMethod.AllocationTypes.Contains(AllocationType.Return) && que.ReturnReelQty == 0)
                {
                    var ressld = WinCEUtils.HttpHelp.PostAbp<ReelMoveResDto>("/api/services/app/Reel/GetIsReturnReel", que).Result;
                    if (ressld.IsContinuity)
                    {
                        txtmag.Text = "提示: 检测到为退料料盘，请输入现有料盘数量。";
                        txtQty.Text = ressld.Reel.Qty.ToString();
                        panel1.Visible = true;
                        txtQty.Focus();
                        txtQty.SelectAll();
                        return;
                    }
                }


                // 如果有收料先检查收料单
                if (_reelMoveMethod.AllocationTypes.Contains(AllocationType.Received) && panReceiveds.Visible)
                {
                    var ressld = WinCEUtils.HttpHelp.PostAbp<GetReceivedsResult>("/api/services/app/Reel/GetReceiveds", que);
                    if (ressld.Success)
                    {
                        if (ressld.Result.ReceivedReelBills.FirstOrDefault(r => r.IQCCheckId == cboIQCCheckId.Text) == null)
                        {
                            if (ressld.Result.ReceivedReelBills.Count > 1)
                            {
                                WinCEUtils.FormHelp.SetTsLab(txtmag, "IQC检验单有多个,请选择IQC检验单", new List<string>() { "Fail" }, Color.Red);
                                cboIQCCheckId.Items.Clear();
                                foreach (var item in ressld.Result.ReceivedReelBills)
                                {
                                    cboIQCCheckId.Items.Add(item.IQCCheckId);
                                }

                                return;
                            }
                            else
                            {
                                cboIQCCheckId.Items.Clear();
                                foreach (var item in ressld.Result.ReceivedReelBills)
                                {
                                    cboIQCCheckId.Items.Add(item.IQCCheckId);
                                    cboIQCCheckId.Text = item.IQCCheckId;
                                }
                            }

                        }
                    }
                    else
                    {
                        DateTime tm2 = DateTime.Now;
                        WinCEUtils.FormHelp.SetTsLab(txtmag, ressld.Error.Message + ressld.Error.Details + "\r\n" + (tm2 - tm1).ToString(), new List<string>() { "Fail" }, Color.Red);

                        txtBarCode.Focus();
                        txtBarCode.SelectAll();

                        return;
                    }
                }
                que = new ReelMoveDto() { ReturnReelQty = int.Parse(txtQty.Text), BarCode = txtBarCode.Text, IQCCheckId = cboIQCCheckId.Text, ExtendShelfLife = 0, IsContinuity = ckbIsContinuity.Checked, ShlefLab = txtShlefLab.Text, ReelMoveMethodId = _reelMoveMethod.Id, IsReturnReel = IsLineReturn };

                // 进行上架
                var res = WinCEUtils.HttpHelp.PostAbp<ReelMoveResDto>("/api/services/app/Reel/ReelMove", que);



                if (res.Success)
                {
                    // 进行赋值

                    lvwReelInfo.Items[0].SubItems.Clear();
                    lvwReelInfo.Items[0].Text = "料卷号";
                    lvwReelInfo.Items[0].SubItems.Add(res.Result.Reel.Id);

                    lvwReelInfo.Items[1].SubItems.Clear();
                    lvwReelInfo.Items[1].Text = "料号";
                    lvwReelInfo.Items[1].SubItems.Add(res.Result.Reel.PartNoId);

                    lvwReelInfo.Items[2].SubItems.Clear();
                    lvwReelInfo.Items[2].Text = "数量";
                    lvwReelInfo.Items[2].SubItems.Add(res.Result.Reel.Qty.ToString());

                    lvwReelInfo.Items[3].SubItems.Clear();
                    lvwReelInfo.Items[3].Text = "生产日期";
                    lvwReelInfo.Items[3].SubItems.Add(res.Result.Reel.DateCode);

                    lvwReelInfo.Items[4].SubItems.Clear();
                    lvwReelInfo.Items[4].Text = "批号";
                    lvwReelInfo.Items[4].SubItems.Add(res.Result.Reel.LotCode);

                    lvwReelInfo.Items[5].SubItems.Clear();
                    lvwReelInfo.Items[5].Text = "供应商";
                    lvwReelInfo.Items[5].SubItems.Add(res.Result.Reel.Supplier);

                    DateTime tm2 = DateTime.Now;
                    //WinCEUtils.FormHelp.SetTsLab(txtmag, res.Result.Msg + "\r\n" + (tm2 - tm1).ToString(), new List<string>() { "OK" }, Color.Green);

                    if (res.Result.Msg.Contains("面别: [C]"))
                    {
                        WinCEUtils.FormHelp.SetTsLab(txtmag, res.Result.Msg + "\r\n" + (tm2 - tm1).ToString(), new List<string>() { "c" }, Color.Green);
                    }
                    else if (res.Result.Msg.Contains("面别: [S]"))
                    {
                        WinCEUtils.FormHelp.SetTsLab(txtmag, res.Result.Msg + "\r\n" + (tm2 - tm1).ToString(), new List<string>() { "s" }, Color.Green);
                    }
                    else
                    {
                        WinCEUtils.FormHelp.SetTsLab(txtmag, res.Result.Msg + "\r\n" + (tm2 - tm1).ToString(), new List<string>() { "OK" }, Color.Green);
                    }

                    if (res.Result.IsContinuity)
                    {
                        txtShlefLab.Text = res.Result.NextShlefLab;
                        txtBarCode.Focus();
                        txtBarCode.SelectAll();

                        // 当前库位亮灯

                        
                    }
                    else
                    {
                        if (panKW.Visible)
                        {
                            txtShlefLab.Focus();
                            txtShlefLab.SelectAll();
                        }
                        else
                        {
                            txtBarCode.Focus();
                            txtBarCode.SelectAll();
                        }
                    }

                    // 亮灯暂时未添加
                    if (panKW.Visible)
                    {
                        HttpHelp.Post<LightMsg>(lightSer + "/api/Light/LightOrder", new StorageLight[] { new StorageLight() 
                            { 
                                ContinuedTime = 10,
                                LightColor =lightIsRGB? LightColor.Green:LightColor.Default, 
                                LightOrder = 2, 
                                MainBoardId = storageLocationDto.MainBoardId, 
                                RackPositionId = storageLocationDto.PositionId 
                            } });
                    }
                }
                else  // 失败后从 失败提示里面解析错误信息
                {
                    DateTime tm2 = DateTime.Now;
                    WinCEUtils.FormHelp.SetTsLab(txtmag, res.Error.Message + res.Error.Details + "\r\n" + (tm2 - tm1).ToString(), new List<string>() { "Fail" }, Color.Red);

                    txtBarCode.Focus();
                    txtBarCode.SelectAll();
                }

                panel1.Visible = false;
                txtQty.Text = "0";

            }
        }

        private void txtShlefLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    // 获取灯信息
                    var storageLocationDto = HttpHelp.GetAbp<StorageLocationDto>("/api/services/app/StorageLocation/Get?Id=" + txtShlefLab.Text, null).Result;

                    // 亮灯暂时未添加
                    HttpHelp.Post<LightMsg>(lightSer + "/api/Light/LightOrder", new StorageLight[] { new StorageLight() 
                    { 
                        ContinuedTime = 10, 
                        LightColor = lightIsRGB? LightColor.Green:LightColor.Default,  
                        LightOrder = 2, 
                        MainBoardId = storageLocationDto.MainBoardId, 
                        RackPositionId = storageLocationDto.PositionId 
                    } });
                    txtBarCode.Focus();
                    txtBarCode.SelectAll();
                }
                catch (Exception ex)
                {
                    txtShlefLab.Focus();
                    txtShlefLab.SelectAll();
                    WinCEUtils.FormHelp.SetTsLab(txtmag, "输入库位标签不合法" + ex.Message, new List<string>() { "Fail" }, Color.Red);
                }


            }
        }

        private void frmReelMove_Load(object sender, EventArgs e)
        {
            this.Text = _reelMoveMethod.Name;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
            else
            {
                if (e.KeyChar == 13)
                {
                    txtBarCode_KeyPress(sender, e);
                }
            }


        }



    }
}

