using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Состояния шаблонов уведомлений
    /// </summary>
    public partial class RoNotificationTemplateState
    {
        public RoNotificationTemplateState()
        {
            RoNotificationTemplates = new HashSet<RoNotificationTemplate>();
        }

        /// <summary>
        /// Идентификатор состояния
        /// </summary>
        public int StateId { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<RoNotificationTemplate> RoNotificationTemplates { get; set; }
    }
}
