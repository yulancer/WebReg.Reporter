using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица атрибутов тарифов
    /// </summary>
    public partial class RoTariffAttribute
    {
        public RoTariffAttribute()
        {
            RoTariffAttributeCas = new HashSet<RoTariffAttributeCa>();
            RoTariffAttributeLimits = new HashSet<RoTariffAttributeLimit>();
        }

        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int? Number { get; set; }
        /// <summary>
        /// Минимальное количество
        /// </summary>
        public int? MinNumber { get; set; }
        /// <summary>
        /// Максимальное количество
        /// </summary>
        public int? MaxNumber { get; set; }
        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int? IndexNumber { get; set; }
        /// <summary>
        /// Минимальный порядковый номер
        /// </summary>
        public int? MinIndex { get; set; }
        /// <summary>
        /// Ограничение
        /// </summary>
        public int? LimitId { get; set; }
        /// <summary>
        /// Срок действия
        /// </summary>
        public int? Validity { get; set; }
        /// <summary>
        /// Ед. времени срока
        /// </summary>
        public int? ValidityUnitId { get; set; }
        /// <summary>
        /// Дни ожидания
        /// </summary>
        public int? WaitingDays { get; set; }
        public int TariffAttributeId { get; set; }
        /// <summary>
        /// Максимальный порядковый номер
        /// </summary>
        public int? MaxIndex { get; set; }

        public virtual RoAttribute Attribute { get; set; } = null!;
        public virtual RoLimit? Limit { get; set; }
        public virtual RoTariff Tariff { get; set; } = null!;
        public virtual RoUnit? ValidityUnit { get; set; }
        public virtual RoTradingPlatformTariffAttribute RoTradingPlatformTariffAttribute { get; set; } = null!;
        public virtual ICollection<RoTariffAttributeCa> RoTariffAttributeCas { get; set; }
        public virtual ICollection<RoTariffAttributeLimit> RoTariffAttributeLimits { get; set; }
    }
}
