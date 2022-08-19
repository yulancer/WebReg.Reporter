using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Типы запросов шаблонов уведомлений
    /// </summary>
    public partial class RoNotificationTemplateRequestType
    {
        public RoNotificationTemplateRequestType()
        {
            RoNotificationTemplateRequests = new HashSet<RoNotificationTemplateRequest>();
        }

        /// <summary>
        /// Тип запроса шаблона
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<RoNotificationTemplateRequest> RoNotificationTemplateRequests { get; set; }
    }
}
