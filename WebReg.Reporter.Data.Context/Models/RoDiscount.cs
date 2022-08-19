using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица скидок
    /// </summary>
    public partial class RoDiscount
    {
        public RoDiscount()
        {
            RoAgentBalanceDetailChangeRequests = new HashSet<RoAgentBalanceDetailChangeRequest>();
            RoContractTariffDiscounts = new HashSet<RoContractTariffDiscount>();
            RoOfdDiscounts = new HashSet<RoOfdDiscount>();
            RoPriceDiscountSteps = new HashSet<RoPriceDiscountStep>();
            RoPriceDiscounts = new HashSet<RoPriceDiscount>();
            RoTariffDiscounts = new HashSet<RoTariffDiscount>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// Тип скидки
        /// </summary>
        public int DiscountTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string DiscountName { get; set; } = null!;
        /// <summary>
        /// Относительная/абсолютная
        /// </summary>
        public bool? Percent { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public decimal? DiscountValue { get; set; }
        /// <summary>
        /// Минимальное значение
        /// </summary>
        public decimal? MinValue { get; set; }
        /// <summary>
        /// Максимальное значение
        /// </summary>
        public decimal? MaxValue { get; set; }
        /// <summary>
        /// Артикул
        /// </summary>
        public string? Article { get; set; }
        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual RoDiscountType DiscountType { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceDetailChangeRequest> RoAgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<RoContractTariffDiscount> RoContractTariffDiscounts { get; set; }
        public virtual ICollection<RoOfdDiscount> RoOfdDiscounts { get; set; }
        public virtual ICollection<RoPriceDiscountStep> RoPriceDiscountSteps { get; set; }
        public virtual ICollection<RoPriceDiscount> RoPriceDiscounts { get; set; }
        public virtual ICollection<RoTariffDiscount> RoTariffDiscounts { get; set; }
    }
}
