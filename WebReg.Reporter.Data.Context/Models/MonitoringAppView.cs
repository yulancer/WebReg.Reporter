using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class MonitoringAppView
    {
        public string? ApplicationName { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool? IsWork { get; set; }
        public string? Description { get; set; }
    }
}
