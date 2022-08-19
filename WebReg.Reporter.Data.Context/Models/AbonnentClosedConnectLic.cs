using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает всех отключеных абонентов ввиду истичения срока действия лица
    /// </summary>
    public partial class AbonnentClosedConnectLic
    {
        public DateTime? DateConnect { get; set; }
        public int? ProductId { get; set; }
        public int? LicenseId { get; set; }
        public int? AgentId { get; set; }
    }
}
