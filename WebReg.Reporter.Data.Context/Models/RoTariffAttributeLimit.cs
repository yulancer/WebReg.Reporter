using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ограничений для атрибутов тарифов
    /// </summary>
    public partial class RoTariffAttributeLimit
    {
        /// <summary>
        /// ИД атрибута тарифа
        /// </summary>
        public int TariffAttributeId { get; set; }
        /// <summary>
        /// ИД ограничения
        /// </summary>
        public int LimitId { get; set; }
        /// <summary>
        /// Значение ограничения
        /// </summary>
        public string? LimitValue { get; set; }

        public virtual RoLimit Limit { get; set; } = null!;
        public virtual RoTariffAttribute TariffAttribute { get; set; } = null!;
    }
}
