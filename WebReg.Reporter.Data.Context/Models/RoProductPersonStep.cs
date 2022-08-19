using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний сотрудников продуктов
    /// </summary>
    public partial class RoProductPersonStep
    {
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int ProductPersonId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoProductPerson ProductPerson { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
