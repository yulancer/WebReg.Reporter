using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица тарифов для плагинов
    /// </summary>
    public partial class RoPluginTariff
    {
        public RoPluginTariff()
        {
            RoMercuryPlugins = new HashSet<RoMercuryPlugin>();
            RoPlugins = new HashSet<RoPlugin>();
            RoRegRequestPlugins = new HashSet<RoRegRequestPlugin>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Плагин
        /// </summary>
        public int PluginId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffName { get; set; } = null!;
        /// <summary>
        /// Протокол
        /// </summary>
        public int? ProtocolId { get; set; }

        public virtual RoPlugin Plugin { get; set; } = null!;
        public virtual RoProtocol? Protocol { get; set; }
        public virtual ICollection<RoMercuryPlugin> RoMercuryPlugins { get; set; }
        public virtual ICollection<RoPlugin> RoPlugins { get; set; }
        public virtual ICollection<RoRegRequestPlugin> RoRegRequestPlugins { get; set; }
    }
}
