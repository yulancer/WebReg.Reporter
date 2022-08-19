using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Месяцный отчет в УФНС
    /// </summary>
    public partial class PeriodicReportToRegionalUfn
    {
        public string? RecipientCode { get; set; }
        public long? CountAll { get; set; }
        public long? CountIp { get; set; }
        public long? ConCountMonth { get; set; }
        public long? IpConCountMonth { get; set; }
        public int? RegionId { get; set; }
    }
}
