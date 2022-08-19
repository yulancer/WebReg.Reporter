using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица список тарифов для тарифного калькулятора.
    /// </summary>
    public partial class RoTariffCalcTariff
    {
        public RoTariffCalcTariff()
        {
            RoTariffCalcPrices = new HashSet<RoTariffCalcPrice>();
            Features = new HashSet<RoTariffCalcFeaturesList>();
            OrgNals = new HashSet<RoTariffCalcOrgNalType>();
            Regions = new HashSet<RoRegion>();
        }

        /// <summary>
        /// Id тарифа
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Имя тарифа
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Id компании
        /// </summary>
        public int? Company { get; set; }
        /// <summary>
        /// Доступные для тарифа направления.
        /// </summary>
        public string? Directions { get; set; }

        public virtual RoTariffCalcCompany? CompanyNavigation { get; set; }
        public virtual ICollection<RoTariffCalcPrice> RoTariffCalcPrices { get; set; }

        public virtual ICollection<RoTariffCalcFeaturesList> Features { get; set; }
        public virtual ICollection<RoTariffCalcOrgNalType> OrgNals { get; set; }
        public virtual ICollection<RoRegion> Regions { get; set; }
    }
}
