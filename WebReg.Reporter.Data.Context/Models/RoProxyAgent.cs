using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица уполномоченных представителей
    /// </summary>
    public partial class RoProxyAgent
    {
        public RoProxyAgent()
        {
            RoProducts = new HashSet<RoProduct>();
            RoRegRequests = new HashSet<RoRegRequest>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProxyAgentId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ProxyAgentName { get; set; } = null!;
        /// <summary>
        /// Организация
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int? ProductId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoOffice? Office { get; set; }
        public virtual RoProduct? Product { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
    }
}
