using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class MonitoringMemberView
    {
        public int? ProductId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }
        public string? Ca { get; set; }
        public string? Pack { get; set; }
        public DateTime? CertEndTime { get; set; }
        public int? CertId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string? StepName { get; set; }
        public string? Message { get; set; }
    }
}
