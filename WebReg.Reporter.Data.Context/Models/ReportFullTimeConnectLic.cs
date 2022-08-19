using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает все штатные смены лица
    /// </summary>
    public partial class ReportFullTimeConnectLic
    {
        public int? LicenseId { get; set; }
        public int? Product { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? InitialTime { get; set; }
        public int? OldLic { get; set; }
        public bool? IsFullTime { get; set; }
        public int? AgentId { get; set; }
    }
}
