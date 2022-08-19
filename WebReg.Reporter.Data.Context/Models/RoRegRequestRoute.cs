using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица маршрутов запроса на регистрацию
    /// </summary>
    public partial class RoRegRequestRoute
    {
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;

        public virtual RoRegRequestRecipient Recipient { get; set; } = null!;
    }
}
