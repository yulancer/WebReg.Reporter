using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов скидок
    /// </summary>
    public partial class RoDiscountType
    {
        public RoDiscountType()
        {
            RoDiscounts = new HashSet<RoDiscount>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int DiscountTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string DiscountTypeName { get; set; } = null!;

        public virtual ICollection<RoDiscount> RoDiscounts { get; set; }
    }
}
