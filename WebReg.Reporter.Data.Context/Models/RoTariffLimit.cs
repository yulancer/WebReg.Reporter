using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ограничений для тарифов
    /// </summary>
    public partial class RoTariffLimit
    {
        /// <summary>
        /// ИД тарифа
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// ИД ограничения
        /// </summary>
        public int LimitId { get; set; }
        /// <summary>
        /// Значение ограничения
        /// </summary>
        public string? LimitValue { get; set; }

        public virtual RoLimit Limit { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
    }
}
