using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица версий БД
    /// </summary>
    public partial class RoPlugin
    {
        public RoPlugin()
        {
            RoMercuryPlugins = new HashSet<RoMercuryPlugin>();
            RoPluginTariffs = new HashSet<RoPluginTariff>();
            RoRegRequestPlugins = new HashSet<RoRegRequestPlugin>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int PluginId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PluginName { get; set; } = null!;
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid PluginGuid { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int? ProtocolId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Основной
        /// </summary>
        public bool? Basic { get; set; }
        /// <summary>
        /// Тариф по умолчанию
        /// </summary>
        public int? DefaultTariffId { get; set; }

        public virtual RoProtocol? Protocol { get; set; }
        public virtual RoPluginTariff? RoPluginTariff { get; set; }
        public virtual ICollection<RoMercuryPlugin> RoMercuryPlugins { get; set; }
        public virtual ICollection<RoPluginTariff> RoPluginTariffs { get; set; }
        public virtual ICollection<RoRegRequestPlugin> RoRegRequestPlugins { get; set; }
    }
}
