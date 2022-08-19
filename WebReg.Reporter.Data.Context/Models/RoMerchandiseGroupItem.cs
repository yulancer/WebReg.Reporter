using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Членство расширений в группах
    /// </summary>
    public partial class RoMerchandiseGroupItem
    {
        /// <summary>
        /// Id группы
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Id расширения
        /// </summary>
        public int? MerchandiseId { get; set; }
        /// <summary>
        /// Обязательное расширение
        /// </summary>
        public bool IsRequired { get; set; }

        public virtual RoMerchandiseGroup? Group { get; set; }
        public virtual RoMerchandise? Merchandise { get; set; }
    }
}
