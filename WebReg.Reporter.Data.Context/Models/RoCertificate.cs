using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сертификатов
    /// </summary>
    public partial class RoCertificate
    {
        public RoCertificate()
        {
            InverseTrustCertificate = new HashSet<RoCertificate>();
            RoAstralWorkflowClients = new HashSet<RoAstralWorkflowClient>();
            RoCaCertificates = new HashSet<RoCaCertificate>();
            RoCertificateIrudRegistrations = new HashSet<RoCertificateIrudRegistration>();
            RoCertificateRequests = new HashSet<RoCertificateRequest>();
            RoCertificateRevokeRequests = new HashSet<RoCertificateRevokeRequest>();
            RoCertificateServices = new HashSet<RoCertificateService>();
            RoCertificateSteps = new HashSet<RoCertificateStep>();
            RoCertificateTariffs = new HashSet<RoCertificateTariff>();
            RoDsses = new HashSet<RoDss>();
            RoGates = new HashSet<RoGate>();
            RoKeys = new HashSet<RoKey>();
            RoMessengerCertificates = new HashSet<RoMessengerCertificate>();
            RoMessengers = new HashSet<RoMessenger>();
            RoOfficeCertificates = new HashSet<RoOfficeCertificate>();
            RoOffices = new HashSet<RoOffice>();
            RoOperatorIrucs = new HashSet<RoOperatorIruc>();
            RoPfrProviders = new HashSet<RoPfrProvider>();
            RoRecipientCertificates = new HashSet<RoRecipientCertificate>();
            RoRecipientUnits = new HashSet<RoRecipientUnit>();
            RoRecipients = new HashSet<RoRecipient>();
            RoSos = new HashSet<RoSo>();
            RoSosCertificates = new HashSet<RoSosCertificate>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Общее имя
        /// </summary>
        public string? CommonName { get; set; }
        /// <summary>
        /// Отпечаток
        /// </summary>
        public string ThumbPrint { get; set; } = null!;
        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string SubjectKeyId { get; set; } = null!;
        /// <summary>
        /// Идентификатор ключа издателя
        /// </summary>
        public string? AuthorityKeyId { get; set; }
        /// <summary>
        /// Общее имя издателя
        /// </summary>
        public string? IssuerCommonName { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int CertificateTypeId { get; set; }
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid CertificateGuid { get; set; }
        /// <summary>
        /// Дата начала действия
        /// </summary>
        public DateTime InitialTime { get; set; }
        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// Серийный номер
        /// </summary>
        public string SerialNumber { get; set; } = null!;
        /// <summary>
        /// Корневой
        /// </summary>
        public int? TrustCertificateId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Печатная форма расписки
        /// </summary>
        public int? ReceiptId { get; set; }

        public virtual RoCertificateType CertificateType { get; set; } = null!;
        public virtual RoFile? Receipt { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoCertificate? TrustCertificate { get; set; }
        public virtual RoCa RoCa { get; set; } = null!;
        public virtual RoCertificateRevocation RoCertificateRevocation { get; set; } = null!;
        public virtual RoRegCertRequest? RoRegCertRequest { get; set; }
        public virtual RoUser? RoUser { get; set; }
        public virtual ICollection<RoCertificate> InverseTrustCertificate { get; set; }
        public virtual ICollection<RoAstralWorkflowClient> RoAstralWorkflowClients { get; set; }
        public virtual ICollection<RoCaCertificate> RoCaCertificates { get; set; }
        public virtual ICollection<RoCertificateIrudRegistration> RoCertificateIrudRegistrations { get; set; }
        public virtual ICollection<RoCertificateRequest> RoCertificateRequests { get; set; }
        public virtual ICollection<RoCertificateRevokeRequest> RoCertificateRevokeRequests { get; set; }
        public virtual ICollection<RoCertificateService> RoCertificateServices { get; set; }
        public virtual ICollection<RoCertificateStep> RoCertificateSteps { get; set; }
        public virtual ICollection<RoCertificateTariff> RoCertificateTariffs { get; set; }
        public virtual ICollection<RoDss> RoDsses { get; set; }
        public virtual ICollection<RoGate> RoGates { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoMessengerCertificate> RoMessengerCertificates { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
        public virtual ICollection<RoOfficeCertificate> RoOfficeCertificates { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoOperatorIruc> RoOperatorIrucs { get; set; }
        public virtual ICollection<RoPfrProvider> RoPfrProviders { get; set; }
        public virtual ICollection<RoRecipientCertificate> RoRecipientCertificates { get; set; }
        public virtual ICollection<RoRecipientUnit> RoRecipientUnits { get; set; }
        public virtual ICollection<RoRecipient> RoRecipients { get; set; }
        public virtual ICollection<RoSo> RoSos { get; set; }
        public virtual ICollection<RoSosCertificate> RoSosCertificates { get; set; }
    }
}
