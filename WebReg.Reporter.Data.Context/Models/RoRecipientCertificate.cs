using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сертификатов получателей
    /// </summary>
    public partial class RoRecipientCertificate
    {
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public int? Index { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
    }
}
