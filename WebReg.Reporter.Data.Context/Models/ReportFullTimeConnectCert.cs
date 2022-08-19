using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает все штатные смены серта
    /// </summary>
    public partial class ReportFullTimeConnectCert
    {
        public int? CertificateId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? InitialTime { get; set; }
        public bool? IsFullTime { get; set; }
        public int? AgentId { get; set; }
    }
}
