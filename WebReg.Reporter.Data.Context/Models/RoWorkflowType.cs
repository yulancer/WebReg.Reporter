using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов документооборота
    /// </summary>
    public partial class RoWorkflowType
    {
        public RoWorkflowType()
        {
            RoPotentialAbonentWorkflows = new HashSet<RoPotentialAbonentWorkflow>();
            RoSubjectTypes = new HashSet<RoSubjectType>();
            RoTransactionTypes = new HashSet<RoTransactionType>();
            RoWorkflowDocTypes = new HashSet<RoWorkflowDocType>();
            RoWorkflows = new HashSet<RoWorkflow>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int WorkflowTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string WorkflowTypeName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentWorkflow> RoPotentialAbonentWorkflows { get; set; }
        public virtual ICollection<RoSubjectType> RoSubjectTypes { get; set; }
        public virtual ICollection<RoTransactionType> RoTransactionTypes { get; set; }
        public virtual ICollection<RoWorkflowDocType> RoWorkflowDocTypes { get; set; }
        public virtual ICollection<RoWorkflow> RoWorkflows { get; set; }
    }
}
