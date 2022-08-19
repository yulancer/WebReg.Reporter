﻿using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица для связи потенциального абонента и тарифа многие ко многим
    /// </summary>
    public partial class RoPotentialAbonentTariffAbonent
    {
        /// <summary>
        /// ID потенциального абонента
        /// </summary>
        public int PotentialAbonentId { get; set; }
        /// <summary>
        /// ID тарифа
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int? Count { get; set; }

        public virtual RoPotentialAbonentTariff Tariff { get; set; } = null!;
    }
}
