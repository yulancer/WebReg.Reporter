using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAgentLocalityRating
    {
        public int? AgentId { get; set; }
        public string? Locality { get; set; }
        public int? RegionId { get; set; }
        public long? Count { get; set; }
        public int? LevelId { get; set; }
    }
}
