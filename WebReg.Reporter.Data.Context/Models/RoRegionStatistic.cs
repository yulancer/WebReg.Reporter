using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление для статистики по регионам
    /// </summary>
    public partial class RoRegionStatistic
    {
        public string? RegionName { get; set; }
        public long? ItsCount { get; set; }
        public long? CountFull { get; set; }
        public decimal? Cf { get; set; }
        public bool? Success { get; set; }
        public long? CountWeek { get; set; }
        public decimal? Price { get; set; }
    }
}
