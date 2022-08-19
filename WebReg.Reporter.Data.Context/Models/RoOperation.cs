using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица операций
    /// </summary>
    public partial class RoOperation
    {
        public RoOperation()
        {
            RoOperationLogs = new HashSet<RoOperationLog>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int OperationId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string OperationName { get; set; } = null!;

        public virtual ICollection<RoOperationLog> RoOperationLogs { get; set; }
    }
}
