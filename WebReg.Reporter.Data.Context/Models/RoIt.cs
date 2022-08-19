using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица рег-номеров подписки ИТС
    /// </summary>
    public partial class RoIt
    {
        public RoIt()
        {
            RoItsHistories = new HashSet<RoItsHistory>();
            RoLicenseDetails = new HashSet<RoLicenseDetail>();
            ItsChildren = new HashSet<RoIt>();
            ItsParents = new HashSet<RoIt>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ItsId { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string? ItsInn { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string? ItsKpp { get; set; }
        /// <summary>
        /// Наименование организации-владельца
        /// </summary>
        public string? ItsName { get; set; }
        /// <summary>
        /// Дата начала подписки
        /// </summary>
        public DateTime? ItsStartDate { get; set; }
        /// <summary>
        /// Дата окончания подписки
        /// </summary>
        public DateTime? ItsEndDate { get; set; }
        /// <summary>
        /// Издание
        /// </summary>
        public string? ItsPublishName { get; set; }
        /// <summary>
        /// Выпусков
        /// </summary>
        public int? ItsPublishCount { get; set; }
        /// <summary>
        /// Платная
        /// </summary>
        public bool? ItsPaid { get; set; }
        /// <summary>
        /// Рег-номер подиски ИТС-Проф
        /// </summary>
        public string RegistrationNumber { get; set; } = null!;
        /// <summary>
        /// Партнер
        /// </summary>
        public int? AgentId { get; set; }
        /// <summary>
        /// Наименование партнера
        /// </summary>
        public string? AgentName { get; set; }
        /// <summary>
        /// ИНН партнера
        /// </summary>
        public string? AgentInn { get; set; }
        /// <summary>
        /// КПП партнера
        /// </summary>
        public string? AgentKpp { get; set; }
        /// <summary>
        /// Дистрибьютор (ЦП)
        /// </summary>
        public string? Distributor { get; set; }
        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string? Locality { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int? RegionId { get; set; }
        /// <summary>
        /// ИНН ЦП
        /// </summary>
        public string? DistributorInn { get; set; }
        /// <summary>
        /// КПП ЦП
        /// </summary>
        public string? DistributorKpp { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Дата внесения подписки
        /// </summary>
        public DateTime? ItsCreationDate { get; set; }

        public virtual RoAgent? Agent { get; set; }
        public virtual RoRegion? Region { get; set; }
        public virtual ICollection<RoItsHistory> RoItsHistories { get; set; }
        public virtual ICollection<RoLicenseDetail> RoLicenseDetails { get; set; }

        public virtual ICollection<RoIt> ItsChildren { get; set; }
        public virtual ICollection<RoIt> ItsParents { get; set; }
    }
}
