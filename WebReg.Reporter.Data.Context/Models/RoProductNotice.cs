using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица периодов времени уведомлений для абонентов
    /// </summary>
    public partial class RoProductNotice
    {
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Смещение времени
        /// </summary>
        public TimeSpan TimeOffset { get; set; }
        /// <summary>
        /// Время начала уведомлений
        /// </summary>
        public TimeOnly BeginTime { get; set; }
        /// <summary>
        /// Время завершения уведомлений
        /// </summary>
        public TimeOnly EndTime { get; set; }

        public virtual RoProduct Product { get; set; } = null!;
    }
}
