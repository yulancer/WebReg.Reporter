using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица связи курьеров с получателями
    /// </summary>
    public partial class RoMessengerRecipient
    {
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Курьер по умолчанию
        /// </summary>
        public bool Default { get; set; }

        public virtual RoMessenger Messenger { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
    }
}
