using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица прайсов
    /// </summary>
    public partial class RoPrice
    {
        public RoPrice()
        {
            RoAgentSchemes = new HashSet<RoAgentScheme>();
            RoPriceDiscountSteps = new HashSet<RoPriceDiscountStep>();
            RoPriceDiscounts = new HashSet<RoPriceDiscount>();
            RoPriceSections = new HashSet<RoPriceSection>();
            RoTariffZones = new HashSet<RoTariffZone>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PriceId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PriceName { get; set; } = null!;
        /// <summary>
        /// Группа
        /// </summary>
        public int PriceGroupId { get; set; }
        /// <summary>
        /// Артикул
        /// </summary>
        public string? Article { get; set; }

        public virtual RoPriceGroup PriceGroup { get; set; } = null!;
        public virtual ICollection<RoAgentScheme> RoAgentSchemes { get; set; }
        public virtual ICollection<RoPriceDiscountStep> RoPriceDiscountSteps { get; set; }
        public virtual ICollection<RoPriceDiscount> RoPriceDiscounts { get; set; }
        public virtual ICollection<RoPriceSection> RoPriceSections { get; set; }
        public virtual ICollection<RoTariffZone> RoTariffZones { get; set; }
    }
}
