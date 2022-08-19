using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сетевых узлов ViPNet
    /// </summary>
    public partial class RoVipnetNode
    {
        public RoVipnetNode()
        {
            RoAgents = new HashSet<RoAgent>();
            RoCas = new HashSet<RoCa>();
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoMessengers = new HashSet<RoMessenger>();
            RoOffices = new HashSet<RoOffice>();
            RoRecipientUpdaters = new HashSet<RoRecipientUpdater>();
            RoRecipients = new HashSet<RoRecipient>();
            RoVipnetUsers = new HashSet<RoVipnetUser>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public string VipnetNodeId { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string? VipnetNodeName { get; set; }

        public virtual ICollection<RoAgent> RoAgents { get; set; }
        public virtual ICollection<RoCa> RoCas { get; set; }
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoRecipientUpdater> RoRecipientUpdaters { get; set; }
        public virtual ICollection<RoRecipient> RoRecipients { get; set; }
        public virtual ICollection<RoVipnetUser> RoVipnetUsers { get; set; }
    }
}
