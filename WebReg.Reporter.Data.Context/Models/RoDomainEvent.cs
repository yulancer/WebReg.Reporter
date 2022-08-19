using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица доменных событий
    /// </summary>
    public partial class RoDomainEvent
    {
        /// <summary>
        /// Идентификатор события
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Тип события
        /// </summary>
        public Guid EventType { get; set; }
        /// <summary>
        /// Тело события
        /// </summary>
        public string EventBody { get; set; } = null!;
        /// <summary>
        /// Событие отправлено в шину
        /// </summary>
        public bool IsPublished { get; set; }
    }
}
