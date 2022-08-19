using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает выборку всех лицензий по продуктам
    /// </summary>
    public partial class RoLicenseInProduct
    {
        public int? ProductId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? LicenseId { get; set; }
        public int? LicenseTypeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
