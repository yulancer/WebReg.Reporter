using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица обновления курьеров
    /// </summary>
    public partial class RoMessengerUpdater
    {
        public RoMessengerUpdater()
        {
            RoMessengers = new HashSet<RoMessenger>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MessengerUpdaterId { get; set; }
        /// <summary>
        /// Код
        /// </summary>
        public string MessengerCode { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string? MessengerName { get; set; }
        /// <summary>
        /// Сервер
        /// </summary>
        public int ServerId { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }
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
        /// Регистрация в ПФР
        /// </summary>
        public bool RegPfr { get; set; }
        /// <summary>
        /// Провайдер ПФР
        /// </summary>
        public int? PfrProviderId { get; set; }
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
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
        /// Ожидать ответ
        /// </summary>
        public bool WaitReply { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }

        public virtual RoMessenger Messenger { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoPfrProvider? PfrProvider { get; set; }
        public virtual RoProtocol Protocol { get; set; } = null!;
        public virtual RoServer Server { get; set; } = null!;
        public virtual RoSo? Sos { get; set; }
        public virtual RoVipnetNode? Su { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
    }
}
