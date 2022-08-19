using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний приложений
    /// </summary>
    public partial class RoApplicationStep
    {
        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoApplication Application { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
