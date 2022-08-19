using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class LastLicenseView
    {
        public int? LicenseId { get; set; }
        public DateTime? RegDate { get; set; }
        public int? ProductId { get; set; }
    }
}
