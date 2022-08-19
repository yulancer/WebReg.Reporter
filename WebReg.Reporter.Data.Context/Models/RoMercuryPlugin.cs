using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица плагинов АстралОтчет
    /// </summary>
    public partial class RoMercuryPlugin
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MercuryPluginId { get; set; }
        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }
        /// <summary>
        /// Плагин
        /// </summary>
        public int PluginId { get; set; }
        /// <summary>
        /// Тариф
        /// </summary>
        public int? TariffId { get; set; }

        public virtual RoProduct Mercury { get; set; } = null!;
        public virtual RoPlugin Plugin { get; set; } = null!;
        public virtual RoPluginTariff? RoPluginTariff { get; set; }
    }
}
