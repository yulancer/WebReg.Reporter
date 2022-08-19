using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов сертификатов
    /// </summary>
    public partial class RoCertificateType
    {
        public RoCertificateType()
        {
            RoCertificates = new HashSet<RoCertificate>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CertificateTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CertificateTypeName { get; set; } = null!;

        public virtual ICollection<RoCertificate> RoCertificates { get; set; }
    }
}
