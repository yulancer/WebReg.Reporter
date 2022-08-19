using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoSalecenterRegionView
    {
        public int? SaleCenterId { get; set; }
        public int? RegionId { get; set; }
        public long? AllCount { get; set; }
    }
}
