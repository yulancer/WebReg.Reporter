using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица офисов
    /// </summary>
    public partial class RoOffice
    {
        public RoOffice()
        {
            RoAbonentCounts = new HashSet<RoAbonentCount>();
            RoAbonents = new HashSet<RoAbonent>();
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoAgentBalanceOffices = new HashSet<RoAgentBalanceOffice>();
            RoAgentContracts = new HashSet<RoAgentContract>();
            RoCheckingSchemes = new HashSet<RoCheckingScheme>();
            RoCompanyGroups = new HashSet<RoCompanyGroup>();
            RoContracts = new HashSet<RoContract>();
            RoGateProductTypes = new HashSet<RoGateProductType>();
            RoLicenseDetails = new HashSet<RoLicenseDetail>();
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoOfficeCertificates = new HashSet<RoOfficeCertificate>();
            RoOfficeSettings = new HashSet<RoOfficeSetting>();
            RoOfficeTeams = new HashSet<RoOfficeTeam>();
            RoPeople = new HashSet<RoPerson>();
            RoPotentialAbonents = new HashSet<RoPotentialAbonent>();
            RoPriceSchemeCompetenceCenters = new HashSet<RoPriceScheme>();
            RoPriceSchemeLeadOffices = new HashSet<RoPriceScheme>();
            RoProductTransferLogOffices = new HashSet<RoProductTransferLog>();
            RoProductTransferLogPreviousOffices = new HashSet<RoProductTransferLog>();
            RoProducts = new HashSet<RoProduct>();
            RoProxyAgents = new HashSet<RoProxyAgent>();
            RoRecipientUpdaters = new HashSet<RoRecipientUpdater>();
            RoReflexRules = new HashSet<RoReflexRule>();
            RoRegBankRequests = new HashSet<RoRegBankRequest>();
            RoRegCertRequests = new HashSet<RoRegCertRequest>();
            RoRegRequestTransferLogOffices = new HashSet<RoRegRequestTransferLog>();
            RoRegRequestTransferLogPreviousOffices = new HashSet<RoRegRequestTransferLog>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoRegions = new HashSet<RoRegion>();
            RoUsers = new HashSet<RoUser>();
            Schemes = new HashSet<RoAgentScheme>();
            Users = new HashSet<RoUser>();
        }

        public int OfficeId { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string OfficeName { get; set; } = null!;
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid OfficeGuid { get; set; }
        /// <summary>
        /// СУ
        /// </summary>
        public string? Ruid { get; set; }
        /// <summary>
        /// ЦС
        /// </summary>
        public int DefaultCaId { get; set; }
        /// <summary>
        /// Оператор ИРУЦ
        /// </summary>
        public int? OperatorIrucId { get; set; }
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int DefaultProviderId { get; set; }
        /// <summary>
        /// Дата подключения
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// СОС
        /// </summary>
        public int? DefaultSosId { get; set; }
        public string PfrSystemSender { get; set; } = null!;
        public string PfrSender { get; set; } = null!;
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        public int CertTemplateId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        /// <summary>
        /// Пароль для работы с DSS
        /// </summary>
        public string? Password { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoCertTemplate CertTemplate { get; set; } = null!;
        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoCa DefaultCa { get; set; } = null!;
        public virtual RoProvider DefaultProvider { get; set; } = null!;
        public virtual RoSo? DefaultSos { get; set; }
        public virtual RoOperatorIruc? OperatorIruc { get; set; }
        public virtual RoVipnetNode? Ru { get; set; }
        public virtual ICollection<RoAbonentCount> RoAbonentCounts { get; set; }
        public virtual ICollection<RoAbonent> RoAbonents { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoAgentBalanceOffice> RoAgentBalanceOffices { get; set; }
        public virtual ICollection<RoAgentContract> RoAgentContracts { get; set; }
        public virtual ICollection<RoCheckingScheme> RoCheckingSchemes { get; set; }
        public virtual ICollection<RoCompanyGroup> RoCompanyGroups { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
        public virtual ICollection<RoGateProductType> RoGateProductTypes { get; set; }
        public virtual ICollection<RoLicenseDetail> RoLicenseDetails { get; set; }
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoOfficeCertificate> RoOfficeCertificates { get; set; }
        public virtual ICollection<RoOfficeSetting> RoOfficeSettings { get; set; }
        public virtual ICollection<RoOfficeTeam> RoOfficeTeams { get; set; }
        public virtual ICollection<RoPerson> RoPeople { get; set; }
        public virtual ICollection<RoPotentialAbonent> RoPotentialAbonents { get; set; }
        public virtual ICollection<RoPriceScheme> RoPriceSchemeCompetenceCenters { get; set; }
        public virtual ICollection<RoPriceScheme> RoPriceSchemeLeadOffices { get; set; }
        public virtual ICollection<RoProductTransferLog> RoProductTransferLogOffices { get; set; }
        public virtual ICollection<RoProductTransferLog> RoProductTransferLogPreviousOffices { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoProxyAgent> RoProxyAgents { get; set; }
        public virtual ICollection<RoRecipientUpdater> RoRecipientUpdaters { get; set; }
        public virtual ICollection<RoReflexRule> RoReflexRules { get; set; }
        public virtual ICollection<RoRegBankRequest> RoRegBankRequests { get; set; }
        public virtual ICollection<RoRegCertRequest> RoRegCertRequests { get; set; }
        public virtual ICollection<RoRegRequestTransferLog> RoRegRequestTransferLogOffices { get; set; }
        public virtual ICollection<RoRegRequestTransferLog> RoRegRequestTransferLogPreviousOffices { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoRegion> RoRegions { get; set; }
        public virtual ICollection<RoUser> RoUsers { get; set; }

        public virtual ICollection<RoAgentScheme> Schemes { get; set; }
        public virtual ICollection<RoUser> Users { get; set; }
    }
}
