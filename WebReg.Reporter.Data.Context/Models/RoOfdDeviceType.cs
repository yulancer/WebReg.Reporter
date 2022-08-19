using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdDeviceType
    {
        public RoOfdDeviceType()
        {
            RoOfdDevices = new HashSet<RoOfdDevice>();
        }

        public int OfdDeviceTypeId { get; set; }
        public string ShortName { get; set; } = null!;
        public string? FullName { get; set; }

        public virtual ICollection<RoOfdDevice> RoOfdDevices { get; set; }
    }
}
