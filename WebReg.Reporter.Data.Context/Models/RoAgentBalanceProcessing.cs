using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сверок в обработке
    /// </summary>
    public partial class RoAgentBalanceProcessing
    {
        /// <summary>
        /// Сверка
        /// </summary>
        public int AgentBalanceGroupId { get; set; }
        /// <summary>
        /// Время блокировки
        /// </summary>
        public DateTime BlockTime { get; set; }

        public virtual RoAgentBalanceGroup AgentBalanceGroup { get; set; } = null!;
    }
}
