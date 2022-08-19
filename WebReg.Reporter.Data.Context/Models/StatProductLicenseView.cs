using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class StatProductLicenseView
    {
        public double? Y { get; set; }
        public double? M { get; set; }
        public string? AgentName { get; set; }
        public long? NewLicense { get; set; }
        public long? ExtLicense { get; set; }
        public long? NewLicenseAr { get; set; }
        public long? ExtLicenseAr { get; set; }
        public string? ProductTypeName { get; set; }
        public string? LicenseTypeName { get; set; }
        public string? Registrator { get; set; }
    }
}
