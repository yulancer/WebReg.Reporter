using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица услуг по договору
    /// </summary>
    public partial class RoContractTariff
    {
        public RoContractTariff()
        {
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoAgentRewards = new HashSet<RoAgentReward>();
            RoContractTariffDiscounts = new HashSet<RoContractTariffDiscount>();
            RoContractTariffExtensionContractTariffs = new HashSet<RoContractTariffExtension>();
            RoContractTariffSteps = new HashSet<RoContractTariffStep>();
            RoOfdPins = new HashSet<RoOfdPin>();
            RoOfdProducts = new HashSet<RoOfdProduct>();
            RoTransferTariffLogContractTariffs = new HashSet<RoTransferTariffLog>();
            RoTransferTariffLogPreviousContractTariffs = new HashSet<RoTransferTariffLog>();
            Keys = new HashSet<RoKey>();
            Products = new HashSet<RoProduct>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContractTariffId { get; set; }
        /// <summary>
        /// Договор
        /// </summary>
        public int ContractId { get; set; }
        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateOnly InitialDate { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? EndDate { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Процент скидки
        /// </summary>
        public decimal PercentDiscount { get; set; }
        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Дни ожидания
        /// </summary>
        public int? WaitingDays { get; set; }
        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string? RegistrationNumber { get; set; }
        /// <summary>
        /// Первичный
        /// </summary>
        public bool IsPrimary { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }
        /// <summary>
        /// Затраты
        /// </summary>
        public decimal? Cost { get; set; }
        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime? RegistrationDate { get; set; }
        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid ContractTariffGuid { get; set; }

        public virtual RoContract Contract { get; set; } = null!;
        public virtual RoPriceTariff RoPriceTariff { get; set; } = null!;
        public virtual RoPriceSection Section { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual RoContractTariffExtension RoContractTariffExtensionExtension { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoAgentReward> RoAgentRewards { get; set; }
        public virtual ICollection<RoContractTariffDiscount> RoContractTariffDiscounts { get; set; }
        public virtual ICollection<RoContractTariffExtension> RoContractTariffExtensionContractTariffs { get; set; }
        public virtual ICollection<RoContractTariffStep> RoContractTariffSteps { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
        public virtual ICollection<RoOfdProduct> RoOfdProducts { get; set; }
        public virtual ICollection<RoTransferTariffLog> RoTransferTariffLogContractTariffs { get; set; }
        public virtual ICollection<RoTransferTariffLog> RoTransferTariffLogPreviousContractTariffs { get; set; }

        public virtual ICollection<RoKey> Keys { get; set; }
        public virtual ICollection<RoProduct> Products { get; set; }
    }
}
