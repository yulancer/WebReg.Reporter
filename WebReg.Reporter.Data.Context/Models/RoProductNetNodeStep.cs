using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица логов изменений статусов гейтов продуктов
    /// </summary>
    public partial class RoProductNetNodeStep
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public int ProductNetNodeStepId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Время смены шага
        /// </summary>
        public DateTime? LogTime { get; set; }

        public virtual RoProductNetNode RoProductNetNode { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
