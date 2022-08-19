using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица услуг прайсов
    /// </summary>
    public partial class RoPriceTariff
    {
        public RoPriceTariff()
        {
            RoContractTariffs = new HashSet<RoContractTariff>();
            RoKcrIssues = new HashSet<RoKcrIssue>();
            RoPriceTariffSteps = new HashSet<RoPriceTariffStep>();
            RoPriceTrends = new HashSet<RoPriceTrend>();
            RoRegRequestTariffs = new HashSet<RoRegRequestTariff>();
            RoTariffDiscounts = new HashSet<RoTariffDiscount>();
        }

        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RegisteredName { get; set; } = null!;
        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }
        /// <summary>
        /// Показывать
        /// </summary>
        public bool? Displayed { get; set; }
        /// <summary>
        /// Артикул
        /// </summary>
        public string? Article { get; set; }
        /// <summary>
        /// Идентификатор позиции в прайсе
        /// </summary>
        public Guid PriceTariffId { get; set; }
        public string? Note { get; set; }
        /// <summary>
        /// Краткое описание тарифа
        /// </summary>
        public string? ShortNote { get; set; }
        /// <summary>
        /// Маркетинговое название
        /// </summary>
        public string? MarketingName { get; set; }

        public virtual RoPriceSection Section { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoContractTariff> RoContractTariffs { get; set; }
        public virtual ICollection<RoKcrIssue> RoKcrIssues { get; set; }
        public virtual ICollection<RoPriceTariffStep> RoPriceTariffSteps { get; set; }
        public virtual ICollection<RoPriceTrend> RoPriceTrends { get; set; }
        public virtual ICollection<RoRegRequestTariff> RoRegRequestTariffs { get; set; }
        public virtual ICollection<RoTariffDiscount> RoTariffDiscounts { get; set; }
    }
}
