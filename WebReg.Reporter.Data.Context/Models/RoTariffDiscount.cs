using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица скидок для тарифа в прайсе
    /// </summary>
    public partial class RoTariffDiscount
    {
        public RoTariffDiscount()
        {
            RoKcrIssues = new HashSet<RoKcrIssue>();
            RoTariffDiscountRules = new HashSet<RoTariffDiscountRule>();
        }

        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Секция
        /// </summary>
        public int SectionId { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TariffDiscountId { get; set; }
        /// <summary>
        /// Максимальное количество использований
        /// </summary>
        public int? UseLimit { get; set; }
        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateTime? EndTime { get; set; }

        public virtual RoDiscount Discount { get; set; } = null!;
        public virtual RoPriceTariff RoPriceTariff { get; set; } = null!;
        public virtual RoPriceSection Section { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
        public virtual ICollection<RoKcrIssue> RoKcrIssues { get; set; }
        public virtual ICollection<RoTariffDiscountRule> RoTariffDiscountRules { get; set; }
    }
}
