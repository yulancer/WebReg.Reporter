using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний центров регистрации
    /// </summary>
    public partial class RoRaStep
    {
        /// <summary>
        /// Центр регистрации
        /// </summary>
        public int RaId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoRa Ra { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
