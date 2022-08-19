using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица зависимости скидки от наличия определенного тарифа
    /// </summary>
    public partial class RoTariffDiscountRule
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RuleId { get; set; }
        /// <summary>
        /// Cкидка для тарифа в прайсе
        /// </summary>
        public int TariffDiscountId { get; set; }
        /// <summary>
        /// Секция
        /// </summary>
        public int SectionId { get; set; }
        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }

        public virtual RoPriceSection Section { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
        public virtual RoTariffDiscount TariffDiscount { get; set; } = null!;
    }
}
