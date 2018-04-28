using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MESWinCEClient.ReelMove.Dtos
{
    public class ReceivedReelBillDto
    {
        public string Id { get; set; }
        public string ReceivedId { get; set; }
        public string PoId { get; set; }
        public string IQCCheckId { get; set; }
        public string PartNoId { get; set; }
        public int Qty { get; set; }
        public int ReceivedQty { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetReceivedsResult
    {
        public string Msg { get; set; }

        public ICollection<ReceivedReelBillDto> ReceivedReelBills { get; set; }
    }
}
