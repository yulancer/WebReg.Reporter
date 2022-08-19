using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица плагинов заявлений на регистрацию
    /// </summary>
    public partial class RoRegRequestPlugin
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestPluginId { get; set; }
        /// <summary>
        /// Плагин
        /// </summary>
        public int RegRequestId { get; set; }
        public int PluginId { get; set; }
        /// <summary>
        /// Тариф
        /// </summary>
        public int? TariffId { get; set; }

        public virtual RoPlugin Plugin { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoPluginTariff? RoPluginTariff { get; set; }
    }
}
