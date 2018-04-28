using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZC.HttpUtils;

namespace BatchEditSlotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 设置服务器 地址

            IniFilesHelp.Ini.UpdateParam("BaseUrl", "http://10.130.44.18:99");

            // 设置租户 Id

            IniFilesHelp.Ini.UpdateParam("TenantId", "1");

            string userId = "admin", pwd = "123qwe";

            // 登陆服务器
            var res = HttpHelp.Login(userId, pwd);

            if (res)
            {
                // 设置料表信息
                var slots = new List<BatchSlotListDto>();

                slots.Add(new BatchSlotListDto()
                {
                    Feeder = "Wide08 Forward02 Small paper",
                    Index = 1,
                    LineSide = SideType.L,
                    Location = "RA12,RA13,RA14,RA19,RA20,RA21",
                    Machine = "CM402-1",
                    MachineType = "CM",
                    PartNoId = "20000000A078MAS",
                    Qty = 10,
                    Side = SideType.L,
                    SlotName = "7",
                    Table = "1"
                });

                slots.Add(new BatchSlotListDto()
                {
                    Feeder = "Wide08 Forward02 Small paper",
                    Index = 2,
                    LineSide = SideType.L,
                    Location = "G3",
                    Machine = "CM402-3",
                    MachineType = "CM",
                    PartNoId = "116000256900MAS",
                    Qty = 10,
                    Side = SideType.L,
                    SlotName = "2",
                    Table = "1"
                });

                slots.Add(new BatchSlotListDto()
                {
                    Feeder = "Wide08 Forward02 Small paper",
                    Index = 3,
                    LineSide = SideType.L,
                    Location = "CA163,CA206,CA226,CA470",
                    Machine = "CM402-1",
                    MachineType = "CM",
                    PartNoId = "2044754A0027MAS",
                    Qty = 10,
                    Side = SideType.L,
                    SlotName = "4",
                    Table = "1"
                });

                var batchSlot = new BatchSlotDto()
                {
                    BoardSide = SideType.B,
                    LineId = "SMTA",
                    Pin = 2,
                    ProductId = "SRAAS9517014J11",
                    Version = "R01A",
                    Slots = slots
                };



                // 向服务器提交料站表信息

                var ress = HttpHelp.PostAbp<List<BatchSlotListDto>>("/api/services/app/Slot/BatchEdit", slots);

                Console.ReadKey();

            }

        }
    }
}
