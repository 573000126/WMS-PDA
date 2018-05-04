using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MESWinCEClient.ReelMove.Dtos
{
    public class
        ReelMoveDto
    {
        public string BarCode { get; set; }

        public string ShlefLab { get; set; }

        public int ExtendShelfLife { get; set; }

        public string ReelMoveMethodId { get; set; }

        public string IQCCheckId { get; set; }


        public bool IsContinuity { get; set; }

        public bool IsReturnReel { get; set; }

        public int ReturnReelQty { get; set; }
    }

    public class ReelMoveResDto
    {
        public string NextShlefLab { get; set; }

        public ReelDto Reel { get; set; }

        public bool IsContinuity { get; set; }

        public string Msg { get; set; }
    }
}
