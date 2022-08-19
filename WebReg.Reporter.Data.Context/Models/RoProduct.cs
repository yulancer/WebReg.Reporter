using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица продуктов
    /// </summary>
    public partial class RoProduct
    {
        public RoProduct()
        {
            RoCertificateIrudRegistrations = new HashSet<RoCertificateIrudRegistration>();
            RoCertificateTariffs = new HashSet<RoCertificateTariff>();
            RoContacts = new HashSet<RoContact>();
            RoLicenses = new HashSet<RoLicense>();
            RoMercuryMessengerSteps = new HashSet<RoMercuryMessengerStep>();
            RoMercuryMessengers = new HashSet<RoMercuryMessenger>();
            RoMercuryPlugins = new HashSet<RoMercuryPlugin>();
            RoMercuryRecipientSteps = new HashSet<RoMercuryRecipientStep>();
            RoMercuryRecipients = new HashSet<RoMercuryRecipient>();
            RoMercuryRoutes = new HashSet<RoMercuryRoute>();
            RoNotificationTemplateRequests = new HashSet<RoNotificationTemplateRequest>();
            RoNotificationTemplates = new HashSet<RoNotificationTemplate>();
            RoOfdProducts = new HashSet<RoOfdProduct>();
            RoPortalAccounts = new HashSet<RoPortalAccount>();
            RoProductCheckings = new HashSet<RoProductChecking>();
            RoProductNetNodes = new HashSet<RoProductNetNode>();
            RoProductPeople = new HashSet<RoProductPerson>();
            RoProductSteps = new HashSet<RoProductStep>();
            RoProductTransferLogs = new HashSet<RoProductTransferLog>();
            RoProlongationShortData = new HashSet<RoProlongationShortDatum>();
            RoProxyAgents = new HashSet<RoProxyAgent>();
            RoReflexProducts = new HashSet<RoReflexProduct>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoServices = new HashSet<RoService>();
            RoSos = new HashSet<RoSo>();
            RoTokens = new HashSet<RoToken>();
            RoTradingPlatformRegistrationRequests = new HashSet<RoTradingPlatformRegistrationRequest>();
            ContractTariffs = new HashSet<RoContractTariff>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public Guid ProductGuid { get; set; }
        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Договор
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? DateFixed { get; set; }
        /// <summary>
        /// Крупнейший
        /// </summary>
        public bool? FirstRate { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Привязка к СОС
        /// </summary>
        public bool? HardCodeSos { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public int? CategoryId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Зависимый
        /// </summary>
        public bool? AccrRepresent { get; set; }
        /// <summary>
        /// УП
        /// </summary>
        public int? AccrRepresentId { get; set; }
        /// <summary>
        /// Тип РНС ПФР
        /// </summary>
        public bool? StPfr { get; set; }
        /// <summary>
        /// Псевдоним
        /// </summary>
        public string? Pseudonym { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Почтовый логин
        /// </summary>
        public string? MailLogin { get; set; }
        /// <summary>
        /// Почтовый пароль
        /// </summary>
        public string? MailPassword { get; set; }
        /// <summary>
        /// Дата обновления рег-пакета
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Рег. номер продукта
        /// </summary>
        public string? RegistrationNumber { get; set; }
        /// <summary>
        /// Версия программы (конфигурации)
        /// </summary>
        public string? ProgramVersion { get; set; }
        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }
        /// <summary>
        /// Флаг ИТС
        /// </summary>
        public bool? IsIts { get; set; }
        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string? AbonentShortName { get; set; }
        /// <summary>
        /// Полное наименование
        /// </summary>
        public string? AbonentFullName { get; set; }
        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string? AbonentRnsPfr { get; set; }
        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string? AbonentRnsFss { get; set; }
        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string? AbonentKpFss { get; set; }
        /// <summary>
        /// Юридический адрес
        /// </summary>
        public int? AbonentPostalAddressId { get; set; }
        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? AbonentLocationAddressId { get; set; }
        /// <summary>
        /// Эл. почта
        /// </summary>
        public string? AbonentEmail { get; set; }
        /// <summary>
        /// Частичный рег-файл
        /// </summary>
        public bool IsPartial { get; set; }
        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }
        /// <summary>
        /// СМС подтверждение
        /// </summary>
        public bool SmsConfirmation { get; set; }
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Рег-файл
        /// </summary>
        public int? RegFileId { get; set; }
        /// <summary>
        /// Пакет обновления
        /// </summary>
        public int? PacketId { get; set; }
        /// <summary>
        /// Файл лицензии
        /// </summary>
        public int? LicFileId { get; set; }
        /// <summary>
        /// Отложенное обновление
        /// </summary>
        public bool LazyUpdate { get; set; }
        /// <summary>
        /// УП
        /// </summary>
        public int? ProxyAgentId { get; set; }
        /// <summary>
        /// Конфиденциальные данные
        /// </summary>
        public int? SafeId { get; set; }
        /// <summary>
        /// Идентификатор системы налогообложения
        /// </summary>
        public int? TaxSystemId { get; set; }
        /// <summary>
        /// Идентификатор типа абонента этого продукта
        /// </summary>
        public int? AbonentTypeId { get; set; }
        /// <summary>
        /// ОКПО
        /// </summary>
        public string? Okpo { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoAddr? AbonentLocationAddress { get; set; }
        public virtual RoAddr? AbonentPostalAddress { get; set; }
        public virtual RoAbonentType? AbonentType { get; set; }
        public virtual RoAbonent? AccrRepresentNavigation { get; set; }
        public virtual RoCategory? Category { get; set; }
        public virtual RoContract? Contract { get; set; }
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoProductType ProductType { get; set; } = null!;
        public virtual RoProxyAgent? ProxyAgent { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoStorageType? StorageType { get; set; }
        public virtual RoTaxSystem? TaxSystem { get; set; }
        public virtual RoPoint? TransferPoint { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual RoProductNotice RoProductNotice { get; set; } = null!;
        public virtual RoProductSkrinInfo RoProductSkrinInfo { get; set; } = null!;
        public virtual ICollection<RoCertificateIrudRegistration> RoCertificateIrudRegistrations { get; set; }
        public virtual ICollection<RoCertificateTariff> RoCertificateTariffs { get; set; }
        public virtual ICollection<RoContact> RoContacts { get; set; }
        public virtual ICollection<RoLicense> RoLicenses { get; set; }
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerSteps { get; set; }
        public virtual ICollection<RoMercuryMessenger> RoMercuryMessengers { get; set; }
        public virtual ICollection<RoMercuryPlugin> RoMercuryPlugins { get; set; }
        public virtual ICollection<RoMercuryRecipientStep> RoMercuryRecipientSteps { get; set; }
        public virtual ICollection<RoMercuryRecipient> RoMercuryRecipients { get; set; }
        public virtual ICollection<RoMercuryRoute> RoMercuryRoutes { get; set; }
        public virtual ICollection<RoNotificationTemplateRequest> RoNotificationTemplateRequests { get; set; }
        public virtual ICollection<RoNotificationTemplate> RoNotificationTemplates { get; set; }
        public virtual ICollection<RoOfdProduct> RoOfdProducts { get; set; }
        public virtual ICollection<RoPortalAccount> RoPortalAccounts { get; set; }
        public virtual ICollection<RoProductChecking> RoProductCheckings { get; set; }
        public virtual ICollection<RoProductNetNode> RoProductNetNodes { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoProductStep> RoProductSteps { get; set; }
        public virtual ICollection<RoProductTransferLog> RoProductTransferLogs { get; set; }
        public virtual ICollection<RoProlongationShortDatum> RoProlongationShortData { get; set; }
        public virtual ICollection<RoProxyAgent> RoProxyAgents { get; set; }
        public virtual ICollection<RoReflexProduct> RoReflexProducts { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoService> RoServices { get; set; }
        public virtual ICollection<RoSo> RoSos { get; set; }
        public virtual ICollection<RoToken> RoTokens { get; set; }
        public virtual ICollection<RoTradingPlatformRegistrationRequest> RoTradingPlatformRegistrationRequests { get; set; }

        public virtual ICollection<RoContractTariff> ContractTariffs { get; set; }
    }
}
