using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает всех подключеных абонентов
    /// </summary>
    public partial class AbonentConnect
    {
        public int? LicenseId { get; set; }
        public DateTime? ConnectionDate { get; set; }
        public int? ProductId { get; set; }
        public int? AbonentId { get; set; }
        public string? OfficeName { get; set; }
        public int? AgentId { get; set; }
    }
}
