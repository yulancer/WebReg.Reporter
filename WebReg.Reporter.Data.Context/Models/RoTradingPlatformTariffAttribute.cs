using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица связей идентификаторов тарифов торговых площадок с внутренними тарифами
    /// </summary>
    public partial class RoTradingPlatformTariffAttribute
    {
        public RoTradingPlatformTariffAttribute()
        {
            RoTradingPlatformRegistrationRequests = new HashSet<RoTradingPlatformRegistrationRequest>();
        }

        /// <summary>
        /// Идентификатор внутреннего атрибута тарифа
        /// </summary>
        public int TariffAttributeId { get; set; }
        /// <summary>
        /// Идентификатор тарифа в торговой площадке
        /// </summary>
        public string? TradingPlatformExternalTariffId { get; set; }

        public virtual RoTariffAttribute TariffAttribute { get; set; } = null!;
        public virtual ICollection<RoTradingPlatformRegistrationRequest> RoTradingPlatformRegistrationRequests { get; set; }
    }
}
