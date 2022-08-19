using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица курьеров
    /// </summary>
    public partial class RoMessenger
    {
        public RoMessenger()
        {
            RoCaMessengers = new HashSet<RoCaMessenger>();
            RoMercuryMessengerSteps = new HashSet<RoMercuryMessengerStep>();
            RoMercuryMessengers = new HashSet<RoMercuryMessenger>();
            RoMercuryRecipients = new HashSet<RoMercuryRecipient>();
            RoMessengerCertificates = new HashSet<RoMessengerCertificate>();
            RoMessengerRecipients = new HashSet<RoMessengerRecipient>();
            RoMessengerSuffixes = new HashSet<RoMessengerSuffix>();
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoReflexMessengers = new HashSet<RoReflexMessenger>();
            RoReflexRules = new HashSet<RoReflexRule>();
            Agents = new HashSet<RoAgent>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Код
        /// </summary>
        public string MessengerCode { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string MessengerName { get; set; } = null!;
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid MessengerGuid { get; set; }
        /// <summary>
        /// Сервер
        /// </summary>
        public int ServerId { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        /// <summary>
        /// Домен СОЭД
        /// </summary>
        public string? DomainSoed { get; set; }
        /// <summary>
        /// СОС
        /// </summary>
        public int? SosId { get; set; }
        /// <summary>
        /// Входящий порт
        /// </summary>
        public int PortIn { get; set; }
        /// <summary>
        /// Исходящий порт
        /// </summary>
        public int PortOut { get; set; }
        /// <summary>
        /// СУ
        /// </summary>
        public string? Suid { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Регистрация в ПФР
        /// </summary>
        public bool RegPfr { get; set; }
        /// <summary>
        /// Провайдер ПФР
        /// </summary>
        public int? PfrProviderId { get; set; }
        /// <summary>
        /// Обновление
        /// </summary>
        public int? MessengerUpdaterId { get; set; }
        /// <summary>
        /// Ожидать ответ
        /// </summary>
        public bool WaitReply { get; set; }
        /// <summary>
        /// Пакет только по одному направлению
        /// </summary>
        public bool? SinglePacket { get; set; }

        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoMessengerUpdater? MessengerUpdater { get; set; }
        public virtual RoPfrProvider? PfrProvider { get; set; }
        public virtual RoProtocol Protocol { get; set; } = null!;
        public virtual RoServer Server { get; set; } = null!;
        public virtual RoSo? Sos { get; set; }
        public virtual RoVipnetNode? Su { get; set; }
        public virtual ICollection<RoCaMessenger> RoCaMessengers { get; set; }
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerSteps { get; set; }
        public virtual ICollection<RoMercuryMessenger> RoMercuryMessengers { get; set; }
        public virtual ICollection<RoMercuryRecipient> RoMercuryRecipients { get; set; }
        public virtual ICollection<RoMessengerCertificate> RoMessengerCertificates { get; set; }
        public virtual ICollection<RoMessengerRecipient> RoMessengerRecipients { get; set; }
        public virtual ICollection<RoMessengerSuffix> RoMessengerSuffixes { get; set; }
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoReflexMessenger> RoReflexMessengers { get; set; }
        public virtual ICollection<RoReflexRule> RoReflexRules { get; set; }

        public virtual ICollection<RoAgent> Agents { get; set; }
    }
}
