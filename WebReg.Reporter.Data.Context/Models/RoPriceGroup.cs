using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица групп прайсов
    /// </summary>
    public partial class RoPriceGroup
    {
        public RoPriceGroup()
        {
            RoPrices = new HashSet<RoPrice>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PriceGroupId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PriceGroupName { get; set; } = null!;

        public virtual ICollection<RoPrice> RoPrices { get; set; }
    }
}
