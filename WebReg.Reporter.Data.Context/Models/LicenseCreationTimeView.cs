using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление с датами создания лицензий
    /// </summary>
    public partial class LicenseCreationTimeView
    {
        public int? LicenseId { get; set; }
        public DateTime? CreationTime { get; set; }
    }
}
