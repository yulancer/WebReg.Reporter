using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает выборку выданых сертификатов за отчетный период
    /// </summary>
    public partial class ReportFromTopConnect
    {
        public long? N { get; set; }
        public string? Partnername { get; set; }
        public long? Count { get; set; }
    }
}
