using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица зон обслуживания точек
    /// </summary>
    public partial class RoPointZone
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PointZoneId { get; set; }
        /// <summary>
        /// Точка
        /// </summary>
        public int PointId { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }

        public virtual RoPoint Point { get; set; } = null!;
        public virtual RoRegion Region { get; set; } = null!;
    }
}
