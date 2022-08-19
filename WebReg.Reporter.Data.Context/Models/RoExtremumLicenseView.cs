using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoExtremumLicenseView
    {
        public int? MinLicenseId { get; set; }
        public int? MaxLicenseId { get; set; }
        public int? ProductId { get; set; }
    }
}
