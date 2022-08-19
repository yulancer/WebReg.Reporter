using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Автоматический отзыв сертификата
    /// </summary>
    public partial class RoCertificateRevocation
    {
        /// <summary>
        /// Отзываемый сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Действие
        /// </summary>
        public int ActionId { get; set; }
        /// <summary>
        /// Причина отзыва
        /// </summary>
        public int? ReasonId { get; set; }
        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string? Note { get; set; }

        public virtual RoCaAction Action { get; set; } = null!;
        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoRevocationReason? Reason { get; set; }
    }
}
