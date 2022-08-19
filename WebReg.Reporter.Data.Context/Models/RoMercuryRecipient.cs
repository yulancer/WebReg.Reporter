using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица получателей АстралОтчет
    /// </summary>
    public partial class RoMercuryRecipient
    {
        public RoMercuryRecipient()
        {
            RoMercuryRoutes = new HashSet<RoMercuryRoute>();
        }

        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Номер участка
        /// </summary>
        public int? Index { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? StepId { get; set; }
        public int? UserId { get; set; }
        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string? PackId { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }

        public virtual RoMercuryMessenger Me { get; set; } = null!;
        public virtual RoProduct Mercury { get; set; } = null!;
        public virtual RoMessenger Messenger { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
        public virtual RoStep? Step { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoMercuryRoute> RoMercuryRoutes { get; set; }
    }
}
