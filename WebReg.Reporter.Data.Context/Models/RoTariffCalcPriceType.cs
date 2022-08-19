using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Типы цен
    /// </summary>
    public partial class RoTariffCalcPriceType
    {
        public RoTariffCalcPriceType()
        {
            RoTariffCalcPrices = new HashSet<RoTariffCalcPrice>();
        }

        /// <summary>
        /// Id типа цены
        /// </summary>
        public int PriceTypeId { get; set; }
        /// <summary>
        /// Описание типа цены
        /// </summary>
        public string PriceDesk { get; set; } = null!;

        public virtual ICollection<RoTariffCalcPrice> RoTariffCalcPrices { get; set; }
    }
}
