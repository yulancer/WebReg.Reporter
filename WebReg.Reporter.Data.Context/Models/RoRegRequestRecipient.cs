using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица получателей запроса на регистрацию
    /// </summary>
    public partial class RoRegRequestRecipient
    {
        public RoRegRequestRecipient()
        {
            RoRegRequestRoutes = new HashSet<RoRegRequestRoute>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Запрос
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }
        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; } = null!;
        /// <summary>
        /// Номер участка
        /// </summary>
        public int? Index { get; set; }

        public virtual RoProtocol Protocol { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual ICollection<RoRegRequestRoute> RoRegRequestRoutes { get; set; }
    }
}
