using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица обновления рабочих сертификатов получателей
    /// </summary>
    public partial class RoRecipientUnitUpdater
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientUnitUpdaterId { get; set; }
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientUpdaterId { get; set; }
        public int Index { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        public virtual RoRecipientUpdater RecipientUpdater { get; set; } = null!;
    }
}
