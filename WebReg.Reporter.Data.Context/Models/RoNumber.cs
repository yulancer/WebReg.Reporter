using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица номеров счетов
    /// </summary>
    public partial class RoNumber
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int NumberId { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public long NumberValue { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
    }
}
