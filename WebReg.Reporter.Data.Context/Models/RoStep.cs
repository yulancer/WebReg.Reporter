using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний
    /// </summary>
    public partial class RoStep
    {
        public RoStep()
        {
            InverseNextStep = new HashSet<RoStep>();
            RoAbonentImportTasks = new HashSet<RoAbonentImportTask>();
            RoAgentBalanceDetailChangeRequestSteps = new HashSet<RoAgentBalanceDetailChangeRequestStep>();
            RoAgentBalanceDetailChangeRequests = new HashSet<RoAgentBalanceDetailChangeRequest>();
            RoApplicationSteps = new HashSet<RoApplicationStep>();
            RoApplications = new HashSet<RoApplication>();
            RoBalanceBuildTasks = new HashSet<RoBalanceBuildTask>();
            RoBlockRequisiteTasks = new HashSet<RoBlockRequisiteTask>();
            RoBulkSkziLicenseUploadTasks = new HashSet<RoBulkSkziLicenseUploadTask>();
            RoCertificateIrudRegistrationCertificateRegistrationSteps = new HashSet<RoCertificateIrudRegistration>();
            RoCertificateIrudRegistrationCertificateStates = new HashSet<RoCertificateIrudRegistration>();
            RoCertificateRequestStepNextSteps = new HashSet<RoCertificateRequestStep>();
            RoCertificateRequestStepPreviousSteps = new HashSet<RoCertificateRequestStep>();
            RoCertificateRequestStepSteps = new HashSet<RoCertificateRequestStep>();
            RoCertificateRequests = new HashSet<RoCertificateRequest>();
            RoCertificateRevokeRequests = new HashSet<RoCertificateRevokeRequest>();
            RoCertificateServices = new HashSet<RoCertificateService>();
            RoCertificateSteps = new HashSet<RoCertificateStep>();
            RoCertificateTariffSteps = new HashSet<RoCertificateTariffStep>();
            RoCertificateTariffs = new HashSet<RoCertificateTariff>();
            RoCertificates = new HashSet<RoCertificate>();
            RoContractSteps = new HashSet<RoContractStep>();
            RoContractTariffSteps = new HashSet<RoContractTariffStep>();
            RoContractTariffs = new HashSet<RoContractTariff>();
            RoContracts = new HashSet<RoContract>();
            RoDssAuthKeySteps = new HashSet<RoDssAuthKeyStep>();
            RoDssAuthKeys = new HashSet<RoDssAuthKey>();
            RoDssAuthSteps = new HashSet<RoDssAuthStep>();
            RoDssAuths = new HashSet<RoDssAuth>();
            RoDssUserAuthSteps = new HashSet<RoDssUserAuthStep>();
            RoDssUsers = new HashSet<RoDssUser>();
            RoInterviewSteps = new HashSet<RoInterviewStep>();
            RoInterviews = new HashSet<RoInterview>();
            RoLicensePoolSteps = new HashSet<RoLicensePoolStep>();
            RoLicensePools = new HashSet<RoLicensePool>();
            RoLicenseSteps = new HashSet<RoLicenseStep>();
            RoLicenses = new HashSet<RoLicense>();
            RoMercuryMessengerStepNextSteps = new HashSet<RoMercuryMessengerStep>();
            RoMercuryMessengerStepPreviousSteps = new HashSet<RoMercuryMessengerStep>();
            RoMercuryMessengerStepSteps = new HashSet<RoMercuryMessengerStep>();
            RoMercuryMessengers = new HashSet<RoMercuryMessenger>();
            RoMercuryRecipientSteps = new HashSet<RoMercuryRecipientStep>();
            RoMercuryRecipients = new HashSet<RoMercuryRecipient>();
            RoOfdPins = new HashSet<RoOfdPin>();
            RoOkopfs = new HashSet<RoOkopf>();
            RoOrders = new HashSet<RoOrder>();
            RoPointSteps = new HashSet<RoPointStep>();
            RoPoints = new HashSet<RoPoint>();
            RoPotentialAbonentSteps = new HashSet<RoPotentialAbonentStep>();
            RoPriceDiscountSteps = new HashSet<RoPriceDiscountStep>();
            RoPriceDiscounts = new HashSet<RoPriceDiscount>();
            RoPriceTariffSteps = new HashSet<RoPriceTariffStep>();
            RoPriceTariffs = new HashSet<RoPriceTariff>();
            RoProductCheckingSteps = new HashSet<RoProductCheckingStep>();
            RoProductCheckings = new HashSet<RoProductChecking>();
            RoProductNetNodeSteps = new HashSet<RoProductNetNodeStep>();
            RoProductNetNodes = new HashSet<RoProductNetNode>();
            RoProductPeople = new HashSet<RoProductPerson>();
            RoProductPersonSteps = new HashSet<RoProductPersonStep>();
            RoProductSteps = new HashSet<RoProductStep>();
            RoProducts = new HashSet<RoProduct>();
            RoRaSteps = new HashSet<RoRaStep>();
            RoRas = new HashSet<RoRa>();
            RoRegBankRequestSteps = new HashSet<RoRegBankRequestStep>();
            RoRegBankRequests = new HashSet<RoRegBankRequest>();
            RoRegCertRequestSteps = new HashSet<RoRegCertRequestStep>();
            RoRegCertRequests = new HashSet<RoRegCertRequest>();
            RoRegRequestCheckingSteps = new HashSet<RoRegRequestCheckingStep>();
            RoRegRequestCheckings = new HashSet<RoRegRequestChecking>();
            RoRegRequestSteps = new HashSet<RoRegRequestStep>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoRejectedRegRequests = new HashSet<RoRejectedRegRequest>();
            RoReports = new HashSet<RoReport>();
            RoRequest1cs = new HashSet<RoRequest1c>();
            RoTradingPlatformRegistrationRequests = new HashSet<RoTradingPlatformRegistrationRequest>();
            RoTransitionNextSteps = new HashSet<RoTransition>();
            RoTransitionSteps = new HashSet<RoTransition>();
            RoWorkflowServiceSteps = new HashSet<RoWorkflowServiceStep>();
            RoWorkflowServices = new HashSet<RoWorkflowService>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string StepName { get; set; } = null!;
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid StepGuid { get; set; }
        /// <summary>
        /// Следущее состояние
        /// </summary>
        public int? NextStepId { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        public virtual RoStep? NextStep { get; set; }
        public virtual ICollection<RoStep> InverseNextStep { get; set; }
        public virtual ICollection<RoAbonentImportTask> RoAbonentImportTasks { get; set; }
        public virtual ICollection<RoAgentBalanceDetailChangeRequestStep> RoAgentBalanceDetailChangeRequestSteps { get; set; }
        public virtual ICollection<RoAgentBalanceDetailChangeRequest> RoAgentBalanceDetailChangeRequests { get; set; }
        public virtual ICollection<RoApplicationStep> RoApplicationSteps { get; set; }
        public virtual ICollection<RoApplication> RoApplications { get; set; }
        public virtual ICollection<RoBalanceBuildTask> RoBalanceBuildTasks { get; set; }
        public virtual ICollection<RoBlockRequisiteTask> RoBlockRequisiteTasks { get; set; }
        public virtual ICollection<RoBulkSkziLicenseUploadTask> RoBulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<RoCertificateIrudRegistration> RoCertificateIrudRegistrationCertificateRegistrationSteps { get; set; }
        public virtual ICollection<RoCertificateIrudRegistration> RoCertificateIrudRegistrationCertificateStates { get; set; }
        public virtual ICollection<RoCertificateRequestStep> RoCertificateRequestStepNextSteps { get; set; }
        public virtual ICollection<RoCertificateRequestStep> RoCertificateRequestStepPreviousSteps { get; set; }
        public virtual ICollection<RoCertificateRequestStep> RoCertificateRequestStepSteps { get; set; }
        public virtual ICollection<RoCertificateRequest> RoCertificateRequests { get; set; }
        public virtual ICollection<RoCertificateRevokeRequest> RoCertificateRevokeRequests { get; set; }
        public virtual ICollection<RoCertificateService> RoCertificateServices { get; set; }
        public virtual ICollection<RoCertificateStep> RoCertificateSteps { get; set; }
        public virtual ICollection<RoCertificateTariffStep> RoCertificateTariffSteps { get; set; }
        public virtual ICollection<RoCertificateTariff> RoCertificateTariffs { get; set; }
        public virtual ICollection<RoCertificate> RoCertificates { get; set; }
        public virtual ICollection<RoContractStep> RoContractSteps { get; set; }
        public virtual ICollection<RoContractTariffStep> RoContractTariffSteps { get; set; }
        public virtual ICollection<RoContractTariff> RoContractTariffs { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
        public virtual ICollection<RoDssAuthKeyStep> RoDssAuthKeySteps { get; set; }
        public virtual ICollection<RoDssAuthKey> RoDssAuthKeys { get; set; }
        public virtual ICollection<RoDssAuthStep> RoDssAuthSteps { get; set; }
        public virtual ICollection<RoDssAuth> RoDssAuths { get; set; }
        public virtual ICollection<RoDssUserAuthStep> RoDssUserAuthSteps { get; set; }
        public virtual ICollection<RoDssUser> RoDssUsers { get; set; }
        public virtual ICollection<RoInterviewStep> RoInterviewSteps { get; set; }
        public virtual ICollection<RoInterview> RoInterviews { get; set; }
        public virtual ICollection<RoLicensePoolStep> RoLicensePoolSteps { get; set; }
        public virtual ICollection<RoLicensePool> RoLicensePools { get; set; }
        public virtual ICollection<RoLicenseStep> RoLicenseSteps { get; set; }
        public virtual ICollection<RoLicense> RoLicenses { get; set; }
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerStepNextSteps { get; set; }
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerStepPreviousSteps { get; set; }
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerStepSteps { get; set; }
        public virtual ICollection<RoMercuryMessenger> RoMercuryMessengers { get; set; }
        public virtual ICollection<RoMercuryRecipientStep> RoMercuryRecipientSteps { get; set; }
        public virtual ICollection<RoMercuryRecipient> RoMercuryRecipients { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
        public virtual ICollection<RoOkopf> RoOkopfs { get; set; }
        public virtual ICollection<RoOrder> RoOrders { get; set; }
        public virtual ICollection<RoPointStep> RoPointSteps { get; set; }
        public virtual ICollection<RoPoint> RoPoints { get; set; }
        public virtual ICollection<RoPotentialAbonentStep> RoPotentialAbonentSteps { get; set; }
        public virtual ICollection<RoPriceDiscountStep> RoPriceDiscountSteps { get; set; }
        public virtual ICollection<RoPriceDiscount> RoPriceDiscounts { get; set; }
        public virtual ICollection<RoPriceTariffStep> RoPriceTariffSteps { get; set; }
        public virtual ICollection<RoPriceTariff> RoPriceTariffs { get; set; }
        public virtual ICollection<RoProductCheckingStep> RoProductCheckingSteps { get; set; }
        public virtual ICollection<RoProductChecking> RoProductCheckings { get; set; }
        public virtual ICollection<RoProductNetNodeStep> RoProductNetNodeSteps { get; set; }
        public virtual ICollection<RoProductNetNode> RoProductNetNodes { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoProductPersonStep> RoProductPersonSteps { get; set; }
        public virtual ICollection<RoProductStep> RoProductSteps { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoRaStep> RoRaSteps { get; set; }
        public virtual ICollection<RoRa> RoRas { get; set; }
        public virtual ICollection<RoRegBankRequestStep> RoRegBankRequestSteps { get; set; }
        public virtual ICollection<RoRegBankRequest> RoRegBankRequests { get; set; }
        public virtual ICollection<RoRegCertRequestStep> RoRegCertRequestSteps { get; set; }
        public virtual ICollection<RoRegCertRequest> RoRegCertRequests { get; set; }
        public virtual ICollection<RoRegRequestCheckingStep> RoRegRequestCheckingSteps { get; set; }
        public virtual ICollection<RoRegRequestChecking> RoRegRequestCheckings { get; set; }
        public virtual ICollection<RoRegRequestStep> RoRegRequestSteps { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoRejectedRegRequest> RoRejectedRegRequests { get; set; }
        public virtual ICollection<RoReport> RoReports { get; set; }
        public virtual ICollection<RoRequest1c> RoRequest1cs { get; set; }
        public virtual ICollection<RoTradingPlatformRegistrationRequest> RoTradingPlatformRegistrationRequests { get; set; }
        public virtual ICollection<RoTransition> RoTransitionNextSteps { get; set; }
        public virtual ICollection<RoTransition> RoTransitionSteps { get; set; }
        public virtual ICollection<RoWorkflowServiceStep> RoWorkflowServiceSteps { get; set; }
        public virtual ICollection<RoWorkflowService> RoWorkflowServices { get; set; }
    }
}
