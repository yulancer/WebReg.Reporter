using System;
using System.Collections.Generic;
using System.Net;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица IP серверов
    /// </summary>
    public partial class RoIp
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int IpId { get; set; }
        /// <summary>
        /// IP Адрес
        /// </summary>
        public IPAddress IpAddress { get; set; } = null!;
        /// <summary>
        /// Сервер
        /// </summary>
        public int ServerId { get; set; }

        public virtual RoServer Server { get; set; } = null!;
    }
}
