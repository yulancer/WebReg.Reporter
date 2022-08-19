using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний услуг, связанных с документооборотом
    /// </summary>
    public partial class RoWorkflowServiceStep
    {
        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoStep Step { get; set; } = null!;
        public virtual RoWorkflow Workflow { get; set; } = null!;
    }
}
