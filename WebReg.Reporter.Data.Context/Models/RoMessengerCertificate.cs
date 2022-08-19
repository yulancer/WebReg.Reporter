using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сертификатов курьеров
    /// </summary>
    public partial class RoMessengerCertificate
    {
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoMessenger Messenger { get; set; } = null!;
    }
}
