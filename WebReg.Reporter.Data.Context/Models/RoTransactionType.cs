using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов транзакций документооборота
    /// </summary>
    public partial class RoTransactionType
    {
        public RoTransactionType()
        {
            RoTransactions = new HashSet<RoTransaction>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransactionTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TransactionTypeName { get; set; } = null!;
        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }

        public virtual RoWorkflowType WorkflowType { get; set; } = null!;
        public virtual ICollection<RoTransaction> RoTransactions { get; set; }
    }
}
