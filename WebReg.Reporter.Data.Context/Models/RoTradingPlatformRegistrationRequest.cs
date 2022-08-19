using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица запросов на регистрацию сертификата в торговой площадке
    /// </summary>
    public partial class RoTradingPlatformRegistrationRequest
    {
        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public int RequestId { get; set; }
        /// <summary>
        /// Идентификатор запроса в торговой площадке
        /// </summary>
        public string? ExternalRequestId { get; set; }
        /// <summary>
        /// Идентификатор связи атрибута тарифа и торговой площадки
        /// </summary>
        public int TradingPlatformTariffAttributeId { get; set; }
        /// <summary>
        /// Идентификатор регистрируемого продукта
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Идентификатор регистрируемого ключа
        /// </summary>
        public int KeyId { get; set; }
        /// <summary>
        /// Статус регистрации
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Ошибка регистрации сертификата
        /// </summary>
        public string? Error { get; set; }

        public virtual RoKey Key { get; set; } = null!;
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoTradingPlatformTariffAttribute TradingPlatformTariffAttribute { get; set; } = null!;
    }
}
