using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class Actual1cProduct
    {
        public int? ProductId { get; set; }
        public DateTime? CreationTime { get; set; }
        public string? ProgramVersion { get; set; }
        public DateOnly? TariffEndTime { get; set; }
        public DateTime? CertEndTime { get; set; }
    }
}
