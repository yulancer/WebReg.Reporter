using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с данными для ЮКБ
    /// </summary>
    public partial class RoPotentialAbonentUcb
    {
        /// <summary>
        /// Идентификатор лида
        /// </summary>
        public int PotentialAbonentId { get; set; }
        /// <summary>
        /// Дата передачи в ЮКБ
        /// </summary>
        public DateTime? UcbTransferDate { get; set; }
        /// <summary>
        /// Менеджер ЮКБ
        /// </summary>
        public int? UcbUserId { get; set; }
        /// <summary>
        /// Номер сертификата ЮКБ
        /// </summary>
        public string? CertNumber { get; set; }

        public virtual RoPotentialAbonent PotentialAbonent { get; set; } = null!;
        public virtual RoUser? UcbUser { get; set; }
    }
}
