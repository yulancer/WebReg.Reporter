using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сертификатов ЦС
    /// </summary>
    public partial class RoCaCertificate
    {
        /// <summary>
        /// Центр сертификации
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoCertificate Certificate { get; set; } = null!;
    }
}
