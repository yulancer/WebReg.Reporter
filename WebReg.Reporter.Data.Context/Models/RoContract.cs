using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица договоров
    /// </summary>
    public partial class RoContract
    {
        public RoContract()
        {
            RoAgents = new HashSet<RoAgent>();
            RoContractSteps = new HashSet<RoContractStep>();
            RoContractTariffs = new HashSet<RoContractTariff>();
            RoProducts = new HashSet<RoProduct>();
            RoProlongationShortData = new HashSet<RoProlongationShortDatum>();
            Licenses = new HashSet<RoLicensePool>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContractId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ContractName { get; set; } = null!;
        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int ContractTypeId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Причина состояния
        /// </summary>
        public string? StepReason { get; set; }
        /// <summary>
        /// Тарифная зона
        /// </summary>
        public int? TariffZoneId { get; set; }
        /// <summary>
        /// Группа компаний
        /// </summary>
        public int? CompanyGroupId { get; set; }
        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid ContractGuid { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoCompanyGroup? CompanyGroup { get; set; }
        public virtual RoContractType ContractType { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoTariffZone? TariffZone { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoAgent> RoAgents { get; set; }
        public virtual ICollection<RoContractStep> RoContractSteps { get; set; }
        public virtual ICollection<RoContractTariff> RoContractTariffs { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoProlongationShortDatum> RoProlongationShortData { get; set; }

        public virtual ICollection<RoLicensePool> Licenses { get; set; }
    }
}
