using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица аккредитаций издателей
    /// </summary>
    public partial class RoIssuerAccreditation
    {
        /// <summary>
        /// Идентификатор аккредитации
        /// </summary>
        public int IssuerAccreditationId { get; set; }
        /// <summary>
        /// Издатель
        /// </summary>
        public int IssuerId { get; set; }
        /// <summary>
        /// Дата получения аккредитации
        /// </summary>
        public DateTime? ReceivedAt { get; set; }
        /// <summary>
        /// Дата отзыва аккредитации
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        public virtual RoIssuer Issuer { get; set; } = null!;
    }
}
