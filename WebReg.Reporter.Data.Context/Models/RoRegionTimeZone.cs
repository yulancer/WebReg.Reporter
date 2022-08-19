using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица временных зон регионов
    /// </summary>
    public partial class RoRegionTimeZone
    {
        /// <summary>
        /// Идентификатор региона
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Смещение времени
        /// </summary>
        public TimeSpan TimeOffset { get; set; }

        public virtual RoRegion Region { get; set; } = null!;
    }
}
