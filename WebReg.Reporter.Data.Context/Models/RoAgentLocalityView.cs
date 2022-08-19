using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAgentLocalityView
    {
        public int? AgentId { get; set; }
        public string? Locality { get; set; }
        public int? RegionId { get; set; }
        public long? PartnerCount { get; set; }
        public long? SaleCenterCount { get; set; }
        public int? LevelId { get; set; }
    }
}
