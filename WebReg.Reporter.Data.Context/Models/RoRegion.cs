using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица регионов
    /// </summary>
    public partial class RoRegion
    {
        public RoRegion()
        {
            RoAbonents = new HashSet<RoAbonent>();
            RoAddrs = new HashSet<RoAddr>();
            RoAgentSchemes = new HashSet<RoAgentScheme>();
            RoIts = new HashSet<RoIt>();
            RoNewsVisibilities = new HashSet<RoNewsVisibility>();
            RoPfrLayoutSchemes = new HashSet<RoPfrLayoutScheme>();
            RoPointZones = new HashSet<RoPointZone>();
            RoPotentialAbonentUserRegions = new HashSet<RoPotentialAbonentUserRegion>();
            RoPotentialAbonents = new HashSet<RoPotentialAbonent>();
            RoPriceSchemes = new HashSet<RoPriceScheme>();
            RoRecipientUpdaters = new HashSet<RoRecipientUpdater>();
            RoRecipients = new HashSet<RoRecipient>();
            RoRegionalAgents = new HashSet<RoRegionalAgent>();
            RoTariffCalcPrices = new HashSet<RoTariffCalcPrice>();
            Agents = new HashSet<RoAgent>();
            Tariffs = new HashSet<RoTariffCalcTariff>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RegionName { get; set; } = null!;
        /// <summary>
        /// Код ФНС
        /// </summary>
        public string? RegionCode { get; set; }
        /// <summary>
        /// Код ПФР
        /// </summary>
        public string? RegionPfrCode { get; set; }
        /// <summary>
        /// Центр компетенции
        /// </summary>
        public int OfficeId { get; set; }

        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoRegionTimeZone RoRegionTimeZone { get; set; } = null!;
        public virtual ICollection<RoAbonent> RoAbonents { get; set; }
        public virtual ICollection<RoAddr> RoAddrs { get; set; }
        public virtual ICollection<RoAgentScheme> RoAgentSchemes { get; set; }
        public virtual ICollection<RoIt> RoIts { get; set; }
        public virtual ICollection<RoNewsVisibility> RoNewsVisibilities { get; set; }
        public virtual ICollection<RoPfrLayoutScheme> RoPfrLayoutSchemes { get; set; }
        public virtual ICollection<RoPointZone> RoPointZones { get; set; }
        public virtual ICollection<RoPotentialAbonentUserRegion> RoPotentialAbonentUserRegions { get; set; }
        public virtual ICollection<RoPotentialAbonent> RoPotentialAbonents { get; set; }
        public virtual ICollection<RoPriceScheme> RoPriceSchemes { get; set; }
        public virtual ICollection<RoRecipientUpdater> RoRecipientUpdaters { get; set; }
        public virtual ICollection<RoRecipient> RoRecipients { get; set; }
        public virtual ICollection<RoRegionalAgent> RoRegionalAgents { get; set; }
        public virtual ICollection<RoTariffCalcPrice> RoTariffCalcPrices { get; set; }

        public virtual ICollection<RoAgent> Agents { get; set; }
        public virtual ICollection<RoTariffCalcTariff> Tariffs { get; set; }
    }
}
