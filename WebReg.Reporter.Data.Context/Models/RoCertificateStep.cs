using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний сертификатов
    /// </summary>
    public partial class RoCertificateStep
    {
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Идентификатор действия
        /// </summary>
        public int? ActionId { get; set; }
        /// <summary>
        /// Идентификатор причины
        /// </summary>
        public int? ReasonId { get; set; }
        /// <summary>
        /// Дата и время начала действия
        /// </summary>
        public DateTime? ActionStartTime { get; set; }
        /// <summary>
        /// Дата и время окончания действия
        /// </summary>
        public DateTime? ActionEndTime { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }

        public virtual RoCaAction? Action { get; set; }
        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoRevocationReason? Reason { get; set; }
        public virtual RoStep Step { get; set; } = null!;
    }
}
