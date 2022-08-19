using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoRegRequestSummaryView
    {
        public string? AgentName { get; set; }
        public string? OfficeName { get; set; }
        public long? Count { get; set; }
    }
}
