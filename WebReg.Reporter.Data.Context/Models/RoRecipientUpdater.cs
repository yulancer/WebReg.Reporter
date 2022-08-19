using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица обновления получателей
    /// </summary>
    public partial class RoRecipientUpdater
    {
        public RoRecipientUpdater()
        {
            RoRecipientUnitUpdaters = new HashSet<RoRecipientUnitUpdater>();
            RoRecipients = new HashSet<RoRecipient>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientUpdaterId { get; set; }
        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string RecipientName { get; set; } = null!;
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }
        /// <summary>
        /// Эл. почта
        /// </summary>
        public string? MailBox { get; set; }
        /// <summary>
        /// СУ
        /// </summary>
        public string? VipnetNodeId { get; set; }
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата подтверждения
        /// </summary>
        public DateTime? ConfirmDate { get; set; }
        /// <summary>
        /// Дата применения
        /// </summary>
        public DateTime? ApplyDate { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Флаг отключения
        /// </summary>
        public bool TurnOff { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoProtocol Protocol { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual RoVipnetNode? VipnetNode { get; set; }
        public virtual ICollection<RoRecipientUnitUpdater> RoRecipientUnitUpdaters { get; set; }
        public virtual ICollection<RoRecipient> RoRecipients { get; set; }
    }
}
