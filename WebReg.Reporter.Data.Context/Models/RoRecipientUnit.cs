using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица рабочих сертификатов получателей
    /// </summary>
    public partial class RoRecipientUnit
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
        /// Номер
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = null!;

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
    }
}
