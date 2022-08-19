using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний скидок прайсов
    /// </summary>
    public partial class RoPriceDiscountStep
    {
        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoDiscount Discount { get; set; } = null!;
        public virtual RoPrice Price { get; set; } = null!;
        public virtual RoPriceDiscount RoPriceDiscount { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
