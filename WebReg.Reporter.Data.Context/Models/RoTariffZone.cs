using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица тарифных зон
    /// </summary>
    public partial class RoTariffZone
    {
        public RoTariffZone()
        {
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoContracts = new HashSet<RoContract>();
            RoPriceSchemes = new HashSet<RoPriceScheme>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int TariffZoneId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffZoneName { get; set; } = null!;
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Прайс
        /// </summary>
        public int PriceId { get; set; }

        public virtual RoPrice PriceNavigation { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
        public virtual ICollection<RoPriceScheme> RoPriceSchemes { get; set; }
    }
}
