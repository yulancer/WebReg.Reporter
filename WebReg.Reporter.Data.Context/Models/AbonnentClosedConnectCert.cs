using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает всех отключеных абонентов ввиду истичения срока действия серта
    /// </summary>
    public partial class AbonnentClosedConnectCert
    {
        public DateTime? EndTime { get; set; }
        public int? CertificateId { get; set; }
        public int? ProductId { get; set; }
        public int? AbonentId { get; set; }
        public int? AgentId { get; set; }
        public DateTime? ConnectionDate { get; set; }
    }
}
