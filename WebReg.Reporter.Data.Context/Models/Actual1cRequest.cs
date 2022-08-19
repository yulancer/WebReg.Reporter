using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class Actual1cRequest
    {
        public int? RegRequestId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LicenseEndTime { get; set; }
        public string? ProgramVersion { get; set; }
    }
}
