using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний проверок по продуктам
    /// </summary>
    public partial class RoProductCheckingStep
    {
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Проверка
        /// </summary>
        public int CheckingId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoProductChecking Checking { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
