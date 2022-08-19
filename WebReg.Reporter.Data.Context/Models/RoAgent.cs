using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица партнеров
    /// </summary>
    public partial class RoAgent
    {
        public RoAgent()
        {
            InverseOldParent = new HashSet<RoAgent>();
            InverseParent = new HashSet<RoAgent>();
            RoAgentAgreements = new HashSet<RoAgentAgreement>();
            RoAgentBalances = new HashSet<RoAgentBalance>();
            RoAgentContracts = new HashSet<RoAgentContract>();
            RoAgentMerchandiseBillFromAgents = new HashSet<RoAgentMerchandise>();
            RoAgentMerchandiseBillToAgents = new HashSet<RoAgentMerchandise>();
            RoAgentRewards = new HashSet<RoAgentReward>();
            RoAgentSchemeAgents = new HashSet<RoAgentScheme>();
            RoAgentSchemeParents = new HashSet<RoAgentScheme>();
            RoAgentSettings = new HashSet<RoAgentSetting>();
            RoCcItsBalances = new HashSet<RoCcItsBalance>();
            RoCertificateTariffs = new HashSet<RoCertificateTariff>();
            RoIts = new HashSet<RoIt>();
            RoItsDistributors = new HashSet<RoItsDistributor>();
            RoNewsVisibilities = new HashSet<RoNewsVisibility>();
            RoNumbers = new HashSet<RoNumber>();
            RoOfdDeviceAgents = new HashSet<RoOfdDevice>();
            RoOfdDeviceAstralKkts = new HashSet<RoOfdDevice>();
            RoOfdDeviceParents = new HashSet<RoOfdDevice>();
            RoOfdPinAgents = new HashSet<RoOfdPin>();
            RoOfdPinParents = new HashSet<RoOfdPin>();
            RoOfdPinTemplates = new HashSet<RoOfdPinTemplate>();
            RoOfdPrefixes = new HashSet<RoOfdPrefix>();
            RoOffices = new HashSet<RoOffice>();
            RoOperatorIrucs = new HashSet<RoOperatorIruc>();
            RoPoints = new HashSet<RoPoint>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoReports = new HashSet<RoReport>();
            RoSendedBillAgentFroms = new HashSet<RoSendedBill>();
            RoSendedBillAgentTos = new HashSet<RoSendedBill>();
            RoServers = new HashSet<RoServer>();
            RoSkziLicenses = new HashSet<RoSkziLicense>();
            RoSos = new HashSet<RoSo>();
            RoUserAgentTrusteds = new HashSet<RoUserAgentTrusted>();
            RoUsers = new HashSet<RoUser>();
            Answers = new HashSet<RoInterviewAnswer>();
            Messengers = new HashSet<RoMessenger>();
            Regions = new HashSet<RoRegion>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string AgentName { get; set; } = null!;
        /// <summary>
        /// СМ
        /// </summary>
        public string? Cuid { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }
        /// <summary>
        /// Владелец
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Абонент
        /// </summary>
        public int? AbonentId { get; set; }
        /// <summary>
        /// Договор
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// Телефон горячей линии
        /// </summary>
        public string? SupportPhone { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string? SupportEmail { get; set; }
        public string? InvoicePrefix { get; set; }
        public int? OldParentId { get; set; }
        /// <summary>
        /// Признак партнёра БИТ
        /// </summary>
        public bool? IsBit { get; set; }
        /// <summary>
        /// Электронная почта партнера
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Телефон партнера
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Код партнера 1С
        /// </summary>
        public string? Code1c { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Признак агента 1С
        /// </summary>
        public bool? Distributor1c { get; set; }
        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid AgentGuid { get; set; }
        /// <summary>
        /// Уровень сертификации партнера
        /// </summary>
        public int? LevelAucId { get; set; }

        public virtual RoAbonent? Abonent { get; set; }
        public virtual RoContract? Contract { get; set; }
        public virtual RoVipnetNode? Cu { get; set; }
        public virtual RoAgentLevel Level { get; set; } = null!;
        public virtual RoAgentLevelAuc? LevelAuc { get; set; }
        public virtual RoAgent? OldParent { get; set; }
        public virtual RoAgent? Parent { get; set; }
        public virtual ICollection<RoAgent> InverseOldParent { get; set; }
        public virtual ICollection<RoAgent> InverseParent { get; set; }
        public virtual ICollection<RoAgentAgreement> RoAgentAgreements { get; set; }
        public virtual ICollection<RoAgentBalance> RoAgentBalances { get; set; }
        public virtual ICollection<RoAgentContract> RoAgentContracts { get; set; }
        public virtual ICollection<RoAgentMerchandise> RoAgentMerchandiseBillFromAgents { get; set; }
        public virtual ICollection<RoAgentMerchandise> RoAgentMerchandiseBillToAgents { get; set; }
        public virtual ICollection<RoAgentReward> RoAgentRewards { get; set; }
        public virtual ICollection<RoAgentScheme> RoAgentSchemeAgents { get; set; }
        public virtual ICollection<RoAgentScheme> RoAgentSchemeParents { get; set; }
        public virtual ICollection<RoAgentSetting> RoAgentSettings { get; set; }
        public virtual ICollection<RoCcItsBalance> RoCcItsBalances { get; set; }
        public virtual ICollection<RoCertificateTariff> RoCertificateTariffs { get; set; }
        public virtual ICollection<RoIt> RoIts { get; set; }
        public virtual ICollection<RoItsDistributor> RoItsDistributors { get; set; }
        public virtual ICollection<RoNewsVisibility> RoNewsVisibilities { get; set; }
        public virtual ICollection<RoNumber> RoNumbers { get; set; }
        public virtual ICollection<RoOfdDevice> RoOfdDeviceAgents { get; set; }
        public virtual ICollection<RoOfdDevice> RoOfdDeviceAstralKkts { get; set; }
        public virtual ICollection<RoOfdDevice> RoOfdDeviceParents { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPinAgents { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPinParents { get; set; }
        public virtual ICollection<RoOfdPinTemplate> RoOfdPinTemplates { get; set; }
        public virtual ICollection<RoOfdPrefix> RoOfdPrefixes { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoOperatorIruc> RoOperatorIrucs { get; set; }
        public virtual ICollection<RoPoint> RoPoints { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoReport> RoReports { get; set; }
        public virtual ICollection<RoSendedBill> RoSendedBillAgentFroms { get; set; }
        public virtual ICollection<RoSendedBill> RoSendedBillAgentTos { get; set; }
        public virtual ICollection<RoServer> RoServers { get; set; }
        public virtual ICollection<RoSkziLicense> RoSkziLicenses { get; set; }
        public virtual ICollection<RoSo> RoSos { get; set; }
        public virtual ICollection<RoUserAgentTrusted> RoUserAgentTrusteds { get; set; }
        public virtual ICollection<RoUser> RoUsers { get; set; }

        public virtual ICollection<RoInterviewAnswer> Answers { get; set; }
        public virtual ICollection<RoMessenger> Messengers { get; set; }
        public virtual ICollection<RoRegion> Regions { get; set; }
    }
}
