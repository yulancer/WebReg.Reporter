using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица тарифов для серверов DSS
    /// </summary>
    public partial class RoDssTariff
    {
        /// <summary>
        /// Идентификатор сервера DSS
        /// </summary>
        public int DssId { get; set; }
        /// <summary>
        /// Идентификатор тарифа
        /// </summary>
        public int TariffId { get; set; }

        public virtual RoDss Dss { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
    }
}
