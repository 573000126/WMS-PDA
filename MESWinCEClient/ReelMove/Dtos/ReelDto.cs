using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MESWinCEClient.ReelMove.Dtos
{
    public class ReelDto
    {
        public string Id { get; set; }
       
        public string PartNoId { get; set; }
        public int Qty { get; set; }

        public string Supplier { get; set; }
        public DateTime MakeDate { get; set; }
      
        public string DateCode { get; set; }
     
        public string LotCode { get; set; }
       
        public string BatchCode { get; set; }

        public bool IsUseed { get; set; }

        public DateTime ExpiryTime { get; set; }

        public int ExtendShelfLife { get; set; }

        public string WorkBillId { get; set; }
        public string MShelfId { get; set; }
        public string MCarId { get; set; }
    }
}
