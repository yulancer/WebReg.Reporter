using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сертификатов СОС
    /// </summary>
    public partial class RoSosCertificate
    {
        /// <summary>
        /// СОС
        /// </summary>
        public int SosId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoSo Sos { get; set; } = null!;
    }
}
