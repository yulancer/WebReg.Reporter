using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAgentRegionRating
    {
        public int? AgentId { get; set; }
        public int? RegionId { get; set; }
        public long? Count { get; set; }
    }
}
