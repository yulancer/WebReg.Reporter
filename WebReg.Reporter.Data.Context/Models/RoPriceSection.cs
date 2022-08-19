using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица секций прайсов
    /// </summary>
    public partial class RoPriceSection
    {
        public RoPriceSection()
        {
            InverseParentSection = new HashSet<RoPriceSection>();
            RoContractTariffs = new HashSet<RoContractTariff>();
            RoPriceTariffSteps = new HashSet<RoPriceTariffStep>();
            RoPriceTariffs = new HashSet<RoPriceTariff>();
            RoPriceTrends = new HashSet<RoPriceTrend>();
            RoRegRequestTariffs = new HashSet<RoRegRequestTariff>();
            RoTariffDiscountRules = new HashSet<RoTariffDiscountRule>();
            RoTariffDiscounts = new HashSet<RoTariffDiscount>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SectionId { get; set; }
        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string SectionName { get; set; } = null!;
        /// <summary>
        /// Родительская секция
        /// </summary>
        public int? ParentSectionId { get; set; }

        public virtual RoPriceSection? ParentSection { get; set; }
        public virtual RoPrice Price { get; set; } = null!;
        public virtual ICollection<RoPriceSection> InverseParentSection { get; set; }
        public virtual ICollection<RoContractTariff> RoContractTariffs { get; set; }
        public virtual ICollection<RoPriceTariffStep> RoPriceTariffSteps { get; set; }
        public virtual ICollection<RoPriceTariff> RoPriceTariffs { get; set; }
        public virtual ICollection<RoPriceTrend> RoPriceTrends { get; set; }
        public virtual ICollection<RoRegRequestTariff> RoRegRequestTariffs { get; set; }
        public virtual ICollection<RoTariffDiscountRule> RoTariffDiscountRules { get; set; }
        public virtual ICollection<RoTariffDiscount> RoTariffDiscounts { get; set; }
    }
}
