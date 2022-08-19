using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица подписок ИТС-Проф
    /// </summary>
    public partial class RoItsProfSubscription
    {
        /// <summary>
        /// Идентификатор ИТС подписки
        /// </summary>
        public int ItsSubscriptionId { get; set; }
        /// <summary>
        /// Наименование ИТС подписки
        /// </summary>
        public string ItsPublishName { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
    }
}
