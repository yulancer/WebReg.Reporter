using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица дублированных получателей
    /// </summary>
    public partial class RoRecipientDuplicate
    {
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid DuplicateGuid { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public int? Index { get; set; }

        public virtual RoRecipient Recipient { get; set; } = null!;
    }
}
