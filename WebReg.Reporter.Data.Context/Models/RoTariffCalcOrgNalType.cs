using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица список типов налогоорганизаций для тарифного калькулятора
    /// </summary>
    public partial class RoTariffCalcOrgNalType
    {
        public RoTariffCalcOrgNalType()
        {
            RoTariffCalcPrices = new HashSet<RoTariffCalcPrice>();
            Tariffs = new HashSet<RoTariffCalcTariff>();
        }

        /// <summary>
        /// Id типов налогоорганизаций.
        /// </summary>
        public int OrgnalId { get; set; }
        /// <summary>
        /// Описание типов налогоорганизаций
        /// </summary>
        public string Name { get; set; } = null!;

        public virtual ICollection<RoTariffCalcPrice> RoTariffCalcPrices { get; set; }

        public virtual ICollection<RoTariffCalcTariff> Tariffs { get; set; }
    }
}
