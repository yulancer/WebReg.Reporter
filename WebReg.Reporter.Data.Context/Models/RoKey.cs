using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ключей
    /// </summary>
    public partial class RoKey
    {
        public RoKey()
        {
            RoCryptoStorageKeys = new HashSet<RoCryptoStorageKey>();
            RoProductDocs = new HashSet<RoProductDoc>();
            RoProductPersonKeys = new HashSet<RoProductPerson>();
            RoProductPersonKeysNavigation = new HashSet<RoProductPersonKey>();
            RoProductPersonReserveKeys = new HashSet<RoProductPerson>();
            RoTradingPlatformRegistrationRequests = new HashSet<RoTradingPlatformRegistrationRequest>();
            ContractTariffs = new HashSet<RoContractTariff>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int KeyId { get; set; }
        /// <summary>
        /// Физ. лицо
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Наименование контейнера
        /// </summary>
        public string ContainerName { get; set; } = null!;
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int ProviderId { get; set; }
        /// <summary>
        /// ЦС
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        /// <summary>
        /// Пользователь ViPNet
        /// </summary>
        public string? VipnetUserId { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string? KeyPassword { get; set; }
        /// <summary>
        /// Парольная фраза
        /// </summary>
        public string? PasswordPhrase { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Пакет
        /// </summary>
        public string? PackId { get; set; }
        /// <summary>
        /// Открытый ключ
        /// </summary>
        public string? PublicKey { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int? CertTemplateId { get; set; }
        /// <summary>
        /// Класс защиты
        /// </summary>
        public int? ProtectionClassId { get; set; }
        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }
        /// <summary>
        /// Экспортируемый ключ
        /// </summary>
        public bool? Eхportable { get; set; }
        /// <summary>
        /// Шаблон УЦ
        /// </summary>
        public int? TemplateId { get; set; }
        /// <summary>
        /// Документооборот
        /// </summary>
        public int? WorkflowId { get; set; }
        /// <summary>
        /// Контейнер
        /// </summary>
        public int? ContainerId { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoCertTemplate? CertTemplate { get; set; }
        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoFile? Container { get; set; }
        public virtual RoPerson Person { get; set; } = null!;
        public virtual RoProtectionClass? ProtectionClass { get; set; }
        public virtual RoProvider Provider { get; set; } = null!;
        public virtual RoCaTemplate? Template { get; set; }
        public virtual RoVipnetUser? VipnetUser { get; set; }
        public virtual RoWorkflow? Workflow { get; set; }
        public virtual ICollection<RoCryptoStorageKey> RoCryptoStorageKeys { get; set; }
        public virtual ICollection<RoProductDoc> RoProductDocs { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPersonKeys { get; set; }
        public virtual ICollection<RoProductPersonKey> RoProductPersonKeysNavigation { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPersonReserveKeys { get; set; }
        public virtual ICollection<RoTradingPlatformRegistrationRequest> RoTradingPlatformRegistrationRequests { get; set; }

        public virtual ICollection<RoContractTariff> ContractTariffs { get; set; }
    }
}
