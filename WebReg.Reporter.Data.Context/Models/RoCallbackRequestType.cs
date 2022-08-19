using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов запросов на обратный звонок
    /// </summary>
    public partial class RoCallbackRequestType
    {
        public RoCallbackRequestType()
        {
            RoCallbackRequests = new HashSet<RoCallbackRequest>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CallbackRequestTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CallbackRequestTypeName { get; set; } = null!;

        public virtual ICollection<RoCallbackRequest> RoCallbackRequests { get; set; }
    }
}
