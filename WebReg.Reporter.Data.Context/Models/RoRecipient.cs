using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица получателей
    /// </summary>
    public partial class RoRecipient
    {
        public RoRecipient()
        {
            RoMercuryRecipientSteps = new HashSet<RoMercuryRecipientStep>();
            RoMercuryRecipients = new HashSet<RoMercuryRecipient>();
            RoMercuryRoutes = new HashSet<RoMercuryRoute>();
            RoMessengerRecipients = new HashSet<RoMessengerRecipient>();
            RoRecipientCertificates = new HashSet<RoRecipientCertificate>();
            RoRecipientDuplicates = new HashSet<RoRecipientDuplicate>();
            RoRecipientUnits = new HashSet<RoRecipientUnit>();
            RoRecipientUpdaters = new HashSet<RoRecipientUpdater>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string RecipientName { get; set; } = null!;
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid RecipientGuid { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        /// <summary>
        /// Эл. почта
        /// </summary>
        public string? MailBox { get; set; }
        /// <summary>
        /// СУ
        /// </summary>
        public string? VipnetNodeId { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Именение наименования
        /// </summary>
        public bool? ChangeName { get; set; }
        /// <summary>
        /// Обновление
        /// </summary>
        public int? RecipientUpdaterId { get; set; }

        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoProtocol Protocol { get; set; } = null!;
        public virtual RoRecipientUpdater? RecipientUpdater { get; set; }
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoVipnetNode? VipnetNode { get; set; }
        public virtual ICollection<RoMercuryRecipientStep> RoMercuryRecipientSteps { get; set; }
        public virtual ICollection<RoMercuryRecipient> RoMercuryRecipients { get; set; }
        public virtual ICollection<RoMercuryRoute> RoMercuryRoutes { get; set; }
        public virtual ICollection<RoMessengerRecipient> RoMessengerRecipients { get; set; }
        public virtual ICollection<RoRecipientCertificate> RoRecipientCertificates { get; set; }
        public virtual ICollection<RoRecipientDuplicate> RoRecipientDuplicates { get; set; }
        public virtual ICollection<RoRecipientUnit> RoRecipientUnits { get; set; }
        public virtual ICollection<RoRecipientUpdater> RoRecipientUpdaters { get; set; }
    }
}
