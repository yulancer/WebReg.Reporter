using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица скидок на покупки
    /// </summary>
    public partial class RoContractTariffDiscount
    {
        /// <summary>
        /// Тариф по договору
        /// </summary>
        public int ContractTariffId { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// Процент скидки
        /// </summary>
        public decimal PercentDiscount { get; set; }
        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum { get; set; }
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoContractTariff ContractTariff { get; set; } = null!;
        public virtual RoDiscount Discount { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
