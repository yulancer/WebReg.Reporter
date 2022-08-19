using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoPotentialAbonentTradingPlatformType
    {
        public RoPotentialAbonentTradingPlatformType()
        {
            RoPotentialAbonentTradingPlatforms = new HashSet<RoPotentialAbonentTradingPlatform>();
        }

        /// <summary>
        /// Идентификатор типа торговой площадки
        /// </summary>
        public int TradingPlatformTypeId { get; set; }
        /// <summary>
        /// Наименование торговой площадки
        /// </summary>
        public string TradingPlatformName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentTradingPlatform> RoPotentialAbonentTradingPlatforms { get; set; }
    }
}
