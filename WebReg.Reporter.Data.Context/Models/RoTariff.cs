using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица тарифов
    /// </summary>
    public partial class RoTariff
    {
        public RoTariff()
        {
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoContractTariffs = new HashSet<RoContractTariff>();
            RoDssTariffs = new HashSet<RoDssTariff>();
            RoModuleTariffs = new HashSet<RoModuleTariff>();
            RoPriceTariffSteps = new HashSet<RoPriceTariffStep>();
            RoPriceTariffs = new HashSet<RoPriceTariff>();
            RoPriceTrends = new HashSet<RoPriceTrend>();
            RoRegRequestTariffs = new HashSet<RoRegRequestTariff>();
            RoTariffAttributes = new HashSet<RoTariffAttribute>();
            RoTariffDiscountRules = new HashSet<RoTariffDiscountRule>();
            RoTariffDiscounts = new HashSet<RoTariffDiscount>();
            RoTariffLimits = new HashSet<RoTariffLimit>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Гуид
        /// </summary>
        public Guid TariffGuid { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffName { get; set; } = null!;
        /// <summary>
        /// Тип
        /// </summary>
        public int TariffTypeId { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public int TariffGroupId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Артикул
        /// </summary>
        public string? Article { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual RoTariffGroup TariffGroup { get; set; } = null!;
        public virtual RoTariffType TariffType { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoContractTariff> RoContractTariffs { get; set; }
        public virtual ICollection<RoDssTariff> RoDssTariffs { get; set; }
        public virtual ICollection<RoModuleTariff> RoModuleTariffs { get; set; }
        public virtual ICollection<RoPriceTariffStep> RoPriceTariffSteps { get; set; }
        public virtual ICollection<RoPriceTariff> RoPriceTariffs { get; set; }
        public virtual ICollection<RoPriceTrend> RoPriceTrends { get; set; }
        public virtual ICollection<RoRegRequestTariff> RoRegRequestTariffs { get; set; }
        public virtual ICollection<RoTariffAttribute> RoTariffAttributes { get; set; }
        public virtual ICollection<RoTariffDiscountRule> RoTariffDiscountRules { get; set; }
        public virtual ICollection<RoTariffDiscount> RoTariffDiscounts { get; set; }
        public virtual ICollection<RoTariffLimit> RoTariffLimits { get; set; }
    }
}
