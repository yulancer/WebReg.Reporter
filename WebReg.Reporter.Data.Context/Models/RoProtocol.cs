using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица протоколов
    /// </summary>
    public partial class RoProtocol
    {
        public RoProtocol()
        {
            RoGateProtocols = new HashSet<RoGateProtocol>();
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoMessengers = new HashSet<RoMessenger>();
            RoPluginTariffs = new HashSet<RoPluginTariff>();
            RoPlugins = new HashSet<RoPlugin>();
            RoRecipientUpdaters = new HashSet<RoRecipientUpdater>();
            RoRecipients = new HashSet<RoRecipient>();
            RoRegRequestRecipients = new HashSet<RoRegRequestRecipient>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ProtocolId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ProtocolName { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Псевдоним
        /// </summary>
        public string? ProtocolAlias { get; set; }

        public virtual ICollection<RoGateProtocol> RoGateProtocols { get; set; }
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
        public virtual ICollection<RoPluginTariff> RoPluginTariffs { get; set; }
        public virtual ICollection<RoPlugin> RoPlugins { get; set; }
        public virtual ICollection<RoRecipientUpdater> RoRecipientUpdaters { get; set; }
        public virtual ICollection<RoRecipient> RoRecipients { get; set; }
        public virtual ICollection<RoRegRequestRecipient> RoRegRequestRecipients { get; set; }
    }
}
