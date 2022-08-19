using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица провайдеров ПФР
    /// </summary>
    public partial class RoPfrProvider
    {
        public RoPfrProvider()
        {
            RoMessengerUpdaters = new HashSet<RoMessengerUpdater>();
            RoMessengers = new HashSet<RoMessenger>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PfrProviderId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PfrProviderName { get; set; } = null!;
        /// <summary>
        /// Система
        /// </summary>
        public string PfrProviderSystem { get; set; } = null!;
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual ICollection<RoMessengerUpdater> RoMessengerUpdaters { get; set; }
        public virtual ICollection<RoMessenger> RoMessengers { get; set; }
    }
}
