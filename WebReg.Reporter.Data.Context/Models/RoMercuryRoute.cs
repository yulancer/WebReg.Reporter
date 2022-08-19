using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица маршрутов АстралОтчет
    /// </summary>
    public partial class RoMercuryRoute
    {
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }

        public virtual RoProduct Mercury { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
        public virtual RoMercuryRecipient RoMercuryRecipient { get; set; } = null!;
    }
}
