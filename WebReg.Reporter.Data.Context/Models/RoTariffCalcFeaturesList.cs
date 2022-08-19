using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Список возможностей
    /// </summary>
    public partial class RoTariffCalcFeaturesList
    {
        public RoTariffCalcFeaturesList()
        {
            RoTariffCalcPrices = new HashSet<RoTariffCalcPrice>();
            Tariffs = new HashSet<RoTariffCalcTariff>();
        }

        /// <summary>
        /// Id возможности
        /// </summary>
        public int FeatureId { get; set; }
        /// <summary>
        /// Описание возможности
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Флаг основная возможность
        /// </summary>
        public bool IsMain { get; set; }

        public virtual ICollection<RoTariffCalcPrice> RoTariffCalcPrices { get; set; }

        public virtual ICollection<RoTariffCalcTariff> Tariffs { get; set; }
    }
}
