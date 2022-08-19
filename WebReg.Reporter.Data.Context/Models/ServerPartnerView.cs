using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class ServerPartnerView
    {
        public string? Id { get; set; }
        public string? PartnerName { get; set; }
        public Guid? Guid { get; set; }
        public string? OfficeName { get; set; }
    }
}
