using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Применение точек
    /// </summary>
    public partial class RoPointUse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PointUseId { get; set; }
        /// <summary>
        /// Точка
        /// </summary>
        public int PointId { get; set; }
        /// <summary>
        /// Тип применения
        /// </summary>
        public int TypeId { get; set; }

        public virtual RoPoint Point { get; set; } = null!;
        public virtual RoPointUseType Type { get; set; } = null!;
    }
}
