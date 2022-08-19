using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// История подписок ИТС
    /// </summary>
    public partial class RoItsHistory
    {
        /// <summary>
        /// ИТС
        /// </summary>
        public int ItsId { get; set; }
        /// <summary>
        /// Издание
        /// </summary>
        public string ItsPublishName { get; set; } = null!;
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateOnly StartDate { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly EndDate { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ItsHistoryId { get; set; }

        public virtual RoIt Its { get; set; } = null!;
    }
}
