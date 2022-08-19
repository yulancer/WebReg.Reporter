using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица аккредитаций УЦ
    /// </summary>
    public partial class RoCaAccreditation
    {
        /// <summary>
        /// Идентификатор аккредитации
        /// </summary>
        public int CaAccreditationId { get; set; }
        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Дата получения аккредитации
        /// </summary>
        public DateTime? ReceivedAt { get; set; }
        /// <summary>
        /// Дата отзыва аккредитации
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
    }
}
