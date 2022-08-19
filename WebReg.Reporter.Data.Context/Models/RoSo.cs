using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица спецоператоров
    /// </summary>
    public partial class RoSo
    {
        public RoSo()
        {
            RoCertificateIrudRegistrations = new HashSet<RoCertificateIrudRegistration>();
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoMessengers = new HashSet<RoMessenger>();
            RoOffices = new HashSet<RoOffice>();
            RoOperatorIrucs = new HashSet<RoOperatorIruc>();
            RoSosCertificates = new HashSet<RoSosCertificate>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SosId { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Префикс
        /// </summary>
        public string PrefixSos { get; set; } = null!;
        /// <summary>
        /// Логин
        /// </summary>
        public string LoginSos { get; set; } = null!;
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Системное имя
        /// </summary>
        public string SystemName { get; set; } = null!;
        /// <summary>
        /// Наименование оператора ЭДО
        /// </summary>
        public string? OperatorName { get; set; }
        /// <summary>
        /// Код получателя ФНС
        /// </summary>
        public string? RecipientCode { get; set; }
        /// <summary>
        /// Учетная запись
        /// </summary>
        public int? ProductId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoProduct? Product { get; set; }
        public virtual ICollection<RoCertificateIrudRegistration> RoCertificateIrudRegistrations { get; set; }
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoOperatorIruc> RoOperatorIrucs { get; set; }
        public virtual ICollection<RoSosCertificate> RoSosCertificates { get; set; }
    }
}
