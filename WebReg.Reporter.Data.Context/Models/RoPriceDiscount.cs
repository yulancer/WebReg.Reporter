using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица скидок прайса
    /// </summary>
    public partial class RoPriceDiscount
    {
        public RoPriceDiscount()
        {
            RoPriceDiscountSteps = new HashSet<RoPriceDiscountStep>();
        }

        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RegisteredName { get; set; } = null!;
        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime InitialTime { get; set; }
        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoDiscount Discount { get; set; } = null!;
        public virtual RoPrice Price { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoPriceDiscountStep> RoPriceDiscountSteps { get; set; }
    }
}
