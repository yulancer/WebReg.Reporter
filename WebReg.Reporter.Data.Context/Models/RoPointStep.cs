using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний точек
    /// </summary>
    public partial class RoPointStep
    {
        /// <summary>
        /// Точка
        /// </summary>
        public int PointId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoPoint Point { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
