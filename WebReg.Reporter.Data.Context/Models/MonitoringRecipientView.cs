using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Мониторинг направлений
    /// </summary>
    public partial class MonitoringRecipientView
    {
        public int? ProductId { get; set; }
        public int? ProtocolId { get; set; }
        public string? ProtocolName { get; set; }
        public string? Code { get; set; }
        public string? Sos { get; set; }
        public string? Server { get; set; }
        public string? Pack { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string? StepName { get; set; }
        public int? StepId { get; set; }
        public string? Message { get; set; }
    }
}
