using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MESWinCEClient.LightService.Dto
{
    public class StorageLocationDto
    {
        public string Id { get; set; }

        public string Code { get; set; }

    
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
   
        public string Info { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
   
        public string Remark { get; set; }

        public string StorageId { get; set; }

        public int MainBoardId { get; set; }

        public int PositionId { get; set; }

        public string StorageLocationTypeId { get; set; }

        public bool IsBright { get; set; }

        public bool IsActive { get; set; }
    }
}
