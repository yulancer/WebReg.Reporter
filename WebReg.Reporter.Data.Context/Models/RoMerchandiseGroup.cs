using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMerchandiseGroup
    {
        public int GroupId { get; set; }
        /// <summary>
        /// Имя группы товаров
        /// </summary>
        public string? GroupName { get; set; }
        /// <summary>
        /// Родительская группа
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Ид группы в 1С
        /// </summary>
        public string? GroupCid { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int? MerchandiseGroupTypeId { get; set; }

        public virtual RoMerchandiseGroupType? MerchandiseGroupType { get; set; }
    }
}
