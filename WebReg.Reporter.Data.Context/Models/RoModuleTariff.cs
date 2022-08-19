using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Тарифы для модуля
    /// </summary>
    public partial class RoModuleTariff
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ModuleTariffId { get; set; }
        /// <summary>
        /// Модуль
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// Тариф
        /// </summary>
        public int TariffId { get; set; }

        public virtual RoModule Module { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
    }
}
