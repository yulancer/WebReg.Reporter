using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Цены тарифов
    /// </summary>
    public partial class RoTariffCalcPrice
    {
        public RoTariffCalcPrice()
        {
            RoTariffCalcComplexPrices = new HashSet<RoTariffCalcComplexPrice>();
        }

        /// <summary>
        /// Id цены
        /// </summary>
        public int PriceId { get; set; }
        /// <summary>
        /// Тип цены например для тарифа или для расширения
        /// </summary>
        public int PriceTypeId { get; set; }
        /// <summary>
        /// Id тарифа если цена для тарифа
        /// </summary>
        public int? TariffId { get; set; }
        /// <summary>
        /// Id возможности если цена для возможности 
        /// </summary>
        public int? FeatureId { get; set; }
        /// <summary>
        /// id региона
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Доступ или тип налогоорганизации для которой доступен тариф
        /// </summary>
        public int OrgNalId { get; set; }
        /// <summary>
        /// Цена в нормальном формате
        /// </summary>
        public decimal? Price { get; set; }

        public virtual RoTariffCalcFeaturesList? Feature { get; set; }
        public virtual RoTariffCalcOrgNalType OrgNal { get; set; } = null!;
        public virtual RoTariffCalcPriceType PriceType { get; set; } = null!;
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoTariffCalcTariff? Tariff { get; set; }
        public virtual ICollection<RoTariffCalcComplexPrice> RoTariffCalcComplexPrices { get; set; }
    }
}
