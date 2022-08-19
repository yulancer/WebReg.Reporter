using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов запросов на регистрацию
    /// </summary>
    public partial class RoRegRequestType
    {
        public RoRegRequestType()
        {
            RoRegRequests = new HashSet<RoRegRequest>();
            RoRejectedRegRequests = new HashSet<RoRejectedRegRequest>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int RegRequestTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RegRequestTypeName { get; set; } = null!;

        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoRejectedRegRequest> RoRejectedRegRequests { get; set; }
    }
}
