using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица признака доверенного пользователя партнера
    /// </summary>
    public partial class RoUserAgentTrusted
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Идентификатор партнера
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Является ли пользователь партнера доверенным
        /// </summary>
        public bool? IsTrusted { get; set; }
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public Guid ProductGuid { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
