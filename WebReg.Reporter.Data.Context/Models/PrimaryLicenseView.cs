using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление по первичным лицензиям
    /// </summary>
    public partial class PrimaryLicenseView
    {
        public int? LicenseId { get; set; }
        public DateTime? RegDate { get; set; }
        public int? ProductId { get; set; }
    }
}
