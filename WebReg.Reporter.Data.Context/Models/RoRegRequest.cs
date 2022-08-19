using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица запросов на регистрацию
    /// </summary>
    public partial class RoRegRequest
    {
        public RoRegRequest()
        {
            RoAstralWorkflowClients = new HashSet<RoAstralWorkflowClient>();
            RoKcrIssues = new HashSet<RoKcrIssue>();
            RoRegRequestAccounts = new HashSet<RoRegRequestAccount>();
            RoRegRequestCheckings = new HashSet<RoRegRequestChecking>();
            RoRegRequestComments = new HashSet<RoRegRequestComment>();
            RoRegRequestContacts = new HashSet<RoRegRequestContact>();
            RoRegRequestDocs = new HashSet<RoRegRequestDoc>();
            RoRegRequestFeedbacks = new HashSet<RoRegRequestFeedback>();
            RoRegRequestGates = new HashSet<RoRegRequestGate>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
            RoRegRequestPlugins = new HashSet<RoRegRequestPlugin>();
            RoRegRequestRecipients = new HashSet<RoRegRequestRecipient>();
            RoRegRequestServices = new HashSet<RoRegRequestService>();
            RoRegRequestSteps = new HashSet<RoRegRequestStep>();
            RoRegRequestTariffs = new HashSet<RoRegRequestTariff>();
            RoRegRequestTransferLogs = new HashSet<RoRegRequestTransferLog>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int RegRequestTypeId { get; set; }
        /// <summary>
        /// Тип абонента
        /// </summary>
        public int? AbonentTypeId { get; set; }
        /// <summary>
        /// ГУИД абонента
        /// </summary>
        public Guid? AbonentGuid { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public int? CategoryId { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// Полное наименование
        /// </summary>
        public string? FullName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Мобильный
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Почтовый адрес
        /// </summary>
        public int? PostalAddressId { get; set; }
        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? LocationAddressId { get; set; }
        /// <summary>
        /// Эл. адрес
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; } = null!;
        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string? RnsPfr { get; set; }
        /// <summary>
        /// ИП работодатель
        /// </summary>
        public bool StPfr { get; set; }
        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string? RnsFss { get; set; }
        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string? KpFss { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int? ProductId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Центр компетенции
        /// </summary>
        public int CenterId { get; set; }
        /// <summary>
        /// Главный абонент
        /// </summary>
        public int? CompanyGroupId { get; set; }
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
        /// ОГРН
        /// </summary>
        public string? Ogrn { get; set; }
        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }
        /// <summary>
        /// СМС подтверждение
        /// </summary>
        public bool SmsConfirmation { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Версия формата
        /// </summary>
        public string? FormatVersion { get; set; }
        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? CompanyGroup2Id { get; set; }
        /// <summary>
        /// УП
        /// </summary>
        public int? ProxyAgentId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int? RequestId { get; set; }
        /// <summary>
        /// ОКПО
        /// </summary>
        public string? Okpo { get; set; }
        /// <summary>
        /// Точка идентификации
        /// </summary>
        public int? IdentPointId { get; set; }
        /// <summary>
        /// ОКОПФ
        /// </summary>
        public int? OkopfId { get; set; }
        /// <summary>
        /// Рег номер продукта до перехода на опции
        /// </summary>
        public string? RegistrationNumberOld { get; set; }
        /// <summary>
        /// Код подчиненности ФСС
        /// </summary>
        public string? EmplParentNo { get; set; }
        /// <summary>
        /// Рег. номер ФСС обособленного подразделения
        /// </summary>
        public string? RnsFssSub { get; set; }

        public virtual RoAbonentType? AbonentType { get; set; }
        public virtual RoCategory? Category { get; set; }
        public virtual RoAgent Center { get; set; } = null!;
        public virtual RoAbonent? CompanyGroup { get; set; }
        public virtual RoCompanyGroup? CompanyGroup2 { get; set; }
        public virtual RoPoint? IdentPoint { get; set; }
        public virtual RoAddr? LocationAddress { get; set; }
        public virtual RoOffice? Office { get; set; }
        public virtual RoOkopf? Okopf { get; set; }
        public virtual RoAddr? PostalAddress { get; set; }
        public virtual RoProduct? Product { get; set; }
        public virtual RoProductType ProductType { get; set; } = null!;
        public virtual RoProxyAgent? ProxyAgent { get; set; }
        public virtual RoRegRequestType RegRequestType { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoStorageType? StorageType { get; set; }
        public virtual RoPoint? TransferPoint { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual RoWorkflow Workflow { get; set; } = null!;
        public virtual RoRegRequestTeam RoRegRequestTeam { get; set; } = null!;
        public virtual ICollection<RoAstralWorkflowClient> RoAstralWorkflowClients { get; set; }
        public virtual ICollection<RoKcrIssue> RoKcrIssues { get; set; }
        public virtual ICollection<RoRegRequestAccount> RoRegRequestAccounts { get; set; }
        public virtual ICollection<RoRegRequestChecking> RoRegRequestCheckings { get; set; }
        public virtual ICollection<RoRegRequestComment> RoRegRequestComments { get; set; }
        public virtual ICollection<RoRegRequestContact> RoRegRequestContacts { get; set; }
        public virtual ICollection<RoRegRequestDoc> RoRegRequestDocs { get; set; }
        public virtual ICollection<RoRegRequestFeedback> RoRegRequestFeedbacks { get; set; }
        public virtual ICollection<RoRegRequestGate> RoRegRequestGates { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
        public virtual ICollection<RoRegRequestPlugin> RoRegRequestPlugins { get; set; }
        public virtual ICollection<RoRegRequestRecipient> RoRegRequestRecipients { get; set; }
        public virtual ICollection<RoRegRequestService> RoRegRequestServices { get; set; }
        public virtual ICollection<RoRegRequestStep> RoRegRequestSteps { get; set; }
        public virtual ICollection<RoRegRequestTariff> RoRegRequestTariffs { get; set; }
        public virtual ICollection<RoRegRequestTransferLog> RoRegRequestTransferLogs { get; set; }
    }
}
