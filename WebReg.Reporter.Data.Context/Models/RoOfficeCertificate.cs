using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сертификатов офиса
    /// </summary>
    public partial class RoOfficeCertificate
    {
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
    }
}
