using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица серверов
    /// </summary>
    public partial class RoServer
    {
        public RoServer()
        {
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoMessengers = new HashSet<RoMessenger>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ServerId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ServerName { get; set; } = null!;
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Входящий домен
        /// </summary>
        public string DomainIn { get; set; } = null!;
        /// <summary>
        /// Исходящий домен
        /// </summary>
        public string DomainOut { get; set; } = null!;
        /// <summary>
        /// Публичный
        /// </summary>
        public bool PublicServer { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
    }
}
