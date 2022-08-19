using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица пользователей
    /// </summary>
    public partial class RoUser
    {
        public RoUser()
        {
            RoAbonentImportTasks = new HashSet<RoAbonentImportTask>();
            RoAbonents = new HashSet<RoAbonent>();
            RoAgentBalanceDetailChangeRequestComments = new HashSet<RoAgentBalanceDetailChangeRequestComment>();
            RoAgentBalanceDetailChangeRequestSteps = new HashSet<RoAgentBalanceDetailChangeRequestStep>();
            RoAgentBalanceDetailChangeRequests = new HashSet<RoAgentBalanceDetailChangeRequest>();
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoAgentSettings = new HashSet<RoAgentSetting>();
            RoBalanceBuildTasks = new HashSet<RoBalanceBuildTask>();
            RoBlockRequisiteTasks = new HashSet<RoBlockRequisiteTask>();
            RoBlockedRequisites = new HashSet<RoBlockedRequisite>();
            RoBulkSkziLicenseUploadTasks = new HashSet<RoBulkSkziLicenseUploadTask>();
            RoCertificateRevokeHistories = new HashSet<RoCertificateRevokeHistory>();
            RoContractSteps = new HashSet<RoContractStep>();
            RoContractTariffDiscounts = new HashSet<RoContractTariffDiscount>();
            RoContractTariffSteps = new HashSet<RoContractTariffStep>();
            RoContractTariffs = new HashSet<RoContractTariff>();
            RoContracts = new HashSet<RoContract>();
            RoDocs = new HashSet<RoDoc>();
            RoFiles = new HashSet<RoFile>();
            RoInterviewSteps = new HashSet<RoInterviewStep>();
            RoInterviews = new HashSet<RoInterview>();
            RoLicenseSteps = new HashSet<RoLicenseStep>();
            RoLogExtendeds = new HashSet<RoLogExtended>();
            RoMercuryRecipientSteps = new HashSet<RoMercuryRecipientStep>();
            RoMercuryRecipients = new HashSet<RoMercuryRecipient>();
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoNews = new HashSet<RoNews>();
            RoNewsBrowsings = new HashSet<RoNewsBrowsing>();
            RoNewsReviews = new HashSet<RoNewsReview>();
            RoOfdDevices = new HashSet<RoOfdDevice>();
            RoOfdPins = new HashSet<RoOfdPin>();
            RoOperationLogs = new HashSet<RoOperationLog>();
            RoOrders = new HashSet<RoOrder>();
            RoPeople = new HashSet<RoPerson>();
            RoPotentialAbonentCalls = new HashSet<RoPotentialAbonentCall>();
            RoPotentialAbonentComments = new HashSet<RoPotentialAbonentComment>();
            RoPotentialAbonentSteps = new HashSet<RoPotentialAbonentStep>();
            RoPotentialAbonentUcbs = new HashSet<RoPotentialAbonentUcb>();
            RoPotentialAbonentUserRegions = new HashSet<RoPotentialAbonentUserRegion>();
            RoPotentialAbonents = new HashSet<RoPotentialAbonent>();
            RoPriceDiscountSteps = new HashSet<RoPriceDiscountStep>();
            RoPriceDiscounts = new HashSet<RoPriceDiscount>();
            RoPriceTariffSteps = new HashSet<RoPriceTariffStep>();
            RoPriceTariffs = new HashSet<RoPriceTariff>();
            RoProcessingProducts = new HashSet<RoProcessingProduct>();
            RoProductCheckingSteps = new HashSet<RoProductCheckingStep>();
            RoProductCheckings = new HashSet<RoProductChecking>();
            RoProductPeople = new HashSet<RoProductPerson>();
            RoProductPersonSteps = new HashSet<RoProductPersonStep>();
            RoProductSteps = new HashSet<RoProductStep>();
            RoProductTransferLogs = new HashSet<RoProductTransferLog>();
            RoProducts = new HashSet<RoProduct>();
            RoRecipientUpdaters = new HashSet<RoRecipientUpdater>();
            RoRefreshTokens = new HashSet<RoRefreshToken>();
            RoRegBankRequestSteps = new HashSet<RoRegBankRequestStep>();
            RoRegBankRequests = new HashSet<RoRegBankRequest>();
            RoRegCertRequestSteps = new HashSet<RoRegCertRequestStep>();
            RoRegCertRequests = new HashSet<RoRegCertRequest>();
            RoRegRequestCheckingSteps = new HashSet<RoRegRequestCheckingStep>();
            RoRegRequestCheckings = new HashSet<RoRegRequestChecking>();
            RoRegRequestComments = new HashSet<RoRegRequestComment>();
            RoRegRequestServices = new HashSet<RoRegRequestService>();
            RoRegRequestSteps = new HashSet<RoRegRequestStep>();
            RoRegRequestTransferLogs = new HashSet<RoRegRequestTransferLog>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoTokens = new HashSet<RoToken>();
            RoUserPromotionConfirmeds = new HashSet<RoUserPromotionConfirmed>();
            RoUserRoles = new HashSet<RoUserRole>();
            RoUserSettings = new HashSet<RoUserSetting>();
            RoUserTrusts = new HashSet<RoUserTrust>();
            Answers = new HashSet<RoInterviewAnswer>();
            Offices = new HashSet<RoOffice>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeWorkId { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Эл почта
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Парольная фраза
        /// </summary>
        public string? PasswordPhrase { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public string? Document { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        public string? DocumentNumber { get; set; }
        /// <summary>
        /// Дата документа
        /// </summary>
        public DateOnly? DocumentDate { get; set; }
        /// <summary>
        /// ФИО по доверенности
        /// </summary>
        public string? AuthorizationName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid UserGuid { get; set; }
        /// <summary>
        /// Сертификат пользователя
        /// </summary>
        public int? CertificateId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoOffice OfficeWork { get; set; } = null!;
        public virtual RoPost? Post { get; set; }
        public virtual RoRole Role { get; set; } = null!;
        public virtual RoUserAgentTrusted RoUserAgentTrusted { get; set; } = null!;
        public virtual RoUserFintender RoUserFintender { get; set; } = null!;
        public virtual ICollection<RoAbonentImportTask> RoAbonentImportTasks { get; set; }
        public virtual ICollection<RoAbonent> RoAbonents { get; set; }
        public virtual ICollection<RoAgentBalanceDetailChangeRequestComment> RoAgentBalanceDetailChangeRequestComments { get; set; }
        public virtual ICollection<RoAgentBalanceDetailChangeRequestStep> RoAgentBalanceDetailChangeRequestSteps { get; set; }
        public virtual ICollection<RoAgentBalanceDetailChangeRequest> RoAgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoAgentSetting> RoAgentSettings { get; set; }
        public virtual ICollection<RoBalanceBuildTask> RoBalanceBuildTasks { get; set; }
        public virtual ICollection<RoBlockRequisiteTask> RoBlockRequisiteTasks { get; set; }
        public virtual ICollection<RoBlockedRequisite> RoBlockedRequisites { get; set; }
        public virtual ICollection<RoBulkSkziLicenseUploadTask> RoBulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<RoCertificateRevokeHistory> RoCertificateRevokeHistories { get; set; }
        public virtual ICollection<RoContractStep> RoContractSteps { get; set; }
        public virtual ICollection<RoContractTariffDiscount> RoContractTariffDiscounts { get; set; }
        public virtual ICollection<RoContractTariffStep> RoContractTariffSteps { get; set; }
        public virtual ICollection<RoContractTariff> RoContractTariffs { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
        public virtual ICollection<RoDoc> RoDocs { get; set; }
        public virtual ICollection<RoFile> RoFiles { get; set; }
        public virtual ICollection<RoInterviewStep> RoInterviewSteps { get; set; }
        public virtual ICollection<RoInterview> RoInterviews { get; set; }
        public virtual ICollection<RoLicenseStep> RoLicenseSteps { get; set; }
        public virtual ICollection<RoLogExtended> RoLogExtendeds { get; set; }
        public virtual ICollection<RoMercuryRecipientStep> RoMercuryRecipientSteps { get; set; }
        public virtual ICollection<RoMercuryRecipient> RoMercuryRecipients { get; set; }
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoNews> RoNews { get; set; }
        public virtual ICollection<RoNewsBrowsing> RoNewsBrowsings { get; set; }
        public virtual ICollection<RoNewsReview> RoNewsReviews { get; set; }
        public virtual ICollection<RoOfdDevice> RoOfdDevices { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
        public virtual ICollection<RoOperationLog> RoOperationLogs { get; set; }
        public virtual ICollection<RoOrder> RoOrders { get; set; }
        public virtual ICollection<RoPerson> RoPeople { get; set; }
        public virtual ICollection<RoPotentialAbonentCall> RoPotentialAbonentCalls { get; set; }
        public virtual ICollection<RoPotentialAbonentComment> RoPotentialAbonentComments { get; set; }
        public virtual ICollection<RoPotentialAbonentStep> RoPotentialAbonentSteps { get; set; }
        public virtual ICollection<RoPotentialAbonentUcb> RoPotentialAbonentUcbs { get; set; }
        public virtual ICollection<RoPotentialAbonentUserRegion> RoPotentialAbonentUserRegions { get; set; }
        public virtual ICollection<RoPotentialAbonent> RoPotentialAbonents { get; set; }
        public virtual ICollection<RoPriceDiscountStep> RoPriceDiscountSteps { get; set; }
        public virtual ICollection<RoPriceDiscount> RoPriceDiscounts { get; set; }
        public virtual ICollection<RoPriceTariffStep> RoPriceTariffSteps { get; set; }
        public virtual ICollection<RoPriceTariff> RoPriceTariffs { get; set; }
        public virtual ICollection<RoProcessingProduct> RoProcessingProducts { get; set; }
        public virtual ICollection<RoProductCheckingStep> RoProductCheckingSteps { get; set; }
        public virtual ICollection<RoProductChecking> RoProductCheckings { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoProductPersonStep> RoProductPersonSteps { get; set; }
        public virtual ICollection<RoProductStep> RoProductSteps { get; set; }
        public virtual ICollection<RoProductTransferLog> RoProductTransferLogs { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoRecipientUpdater> RoRecipientUpdaters { get; set; }
        public virtual ICollection<RoRefreshToken> RoRefreshTokens { get; set; }
        public virtual ICollection<RoRegBankRequestStep> RoRegBankRequestSteps { get; set; }
        public virtual ICollection<RoRegBankRequest> RoRegBankRequests { get; set; }
        public virtual ICollection<RoRegCertRequestStep> RoRegCertRequestSteps { get; set; }
        public virtual ICollection<RoRegCertRequest> RoRegCertRequests { get; set; }
        public virtual ICollection<RoRegRequestCheckingStep> RoRegRequestCheckingSteps { get; set; }
        public virtual ICollection<RoRegRequestChecking> RoRegRequestCheckings { get; set; }
        public virtual ICollection<RoRegRequestComment> RoRegRequestComments { get; set; }
        public virtual ICollection<RoRegRequestService> RoRegRequestServices { get; set; }
        public virtual ICollection<RoRegRequestStep> RoRegRequestSteps { get; set; }
        public virtual ICollection<RoRegRequestTransferLog> RoRegRequestTransferLogs { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoToken> RoTokens { get; set; }
        public virtual ICollection<RoUserPromotionConfirmed> RoUserPromotionConfirmeds { get; set; }
        public virtual ICollection<RoUserRole> RoUserRoles { get; set; }
        public virtual ICollection<RoUserSetting> RoUserSettings { get; set; }
        public virtual ICollection<RoUserTrust> RoUserTrusts { get; set; }

        public virtual ICollection<RoInterviewAnswer> Answers { get; set; }
        public virtual ICollection<RoOffice> Offices { get; set; }
    }
}
