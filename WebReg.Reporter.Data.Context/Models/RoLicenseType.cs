using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoLicenseType
    {
        public RoLicenseType()
        {
            RoLicensePools = new HashSet<RoLicensePool>();
            RoLicenses = new HashSet<RoLicense>();
        }

        public int LicenseTypeId { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string LicenseTypeName { get; set; } = null!;
        /// <summary>
        /// Дата время создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual ICollection<RoLicensePool> RoLicensePools { get; set; }
        public virtual ICollection<RoLicense> RoLicenses { get; set; }
    }
}
