using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MESWinCEClient.ReelMove.Dtos
{

    public class ReelMoveMethodDto
    {
        /// <summary>
        /// 名称
        /// </summary>

        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>

        public string Info { get; set; }
        /// <summary>
        /// 备注
        /// </summary>

        public string Remark { get; set; }

        public ICollection<RMMStorageMapDto> OutStorages { get; set; }

        public ICollection<AllocationType> AllocationTypes { get; set; }

        public AllocationType AllocationType { get; set; }
        public string OutStorageIds { get; set; }

        public bool IsActive { get; set; }
        public string InStorageId { get; set; }

        public string Id { get; set; }
    }


    public class RMMStorageMapDto
    {

        public string ReelMoveMethodId { get; set; }


        public string StorageId { get; set; }

        public bool IsActive { get; set; }
        public string Id { get; set; }
    }


    public enum AllocationType
    {
        /// <summary>
        /// 转仓
        /// </summary>
        Move = 0,
        /// <summary>
        /// 上架
        /// </summary>
        OnSL,
        /// <summary>
        /// 下架
        /// </summary>
        UpSl,
        /// <summary>
        /// 发料
        /// </summary>
        Send,
        /// <summary>
        /// 退料
        /// </summary>
        Return,
        /// <summary>
        /// 收料
        /// </summary>
        Received,
        /// <summary>
        /// 注册
        /// </summary>
        Register,
        /// <summary>
        /// 发首料
        /// </summary>
        SendFirstReel,
        /// <summary>
        /// 补料
        /// </summary>
        SupplyReel,
        /// <summary>
        /// 库位下架
        /// </summary>
        UpByShelf
    }
}
