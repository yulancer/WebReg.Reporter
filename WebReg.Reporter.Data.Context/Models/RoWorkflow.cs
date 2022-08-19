using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица документооборотов
    /// </summary>
    public partial class RoWorkflow
    {
        public RoWorkflow()
        {
            RoKeys = new HashSet<RoKey>();
            RoTransactions = new HashSet<RoTransaction>();
            RoWorkflowFeedbacks = new HashSet<RoWorkflowFeedback>();
            RoWorkflowServiceSteps = new HashSet<RoWorkflowServiceStep>();
            RoWorkflowServices = new HashSet<RoWorkflowService>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int WorkflowTypeId { get; set; }
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid WorkflowGuid { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartedTime { get; set; }
        /// <summary>
        /// Дата завершения
        /// </summary>
        public DateTime? CompletedTime { get; set; }
        /// <summary>
        /// Адрес ответа
        /// </summary>
        public string? CallbackAddress { get; set; }

        public virtual RoWorkflowType WorkflowType { get; set; } = null!;
        public virtual RoRegBankRequest RoRegBankRequest { get; set; } = null!;
        public virtual RoRegCertRequest RoRegCertRequest { get; set; } = null!;
        public virtual RoRegRequest RoRegRequest { get; set; } = null!;
        public virtual RoRejectedRegRequest RoRejectedRegRequest { get; set; } = null!;
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoTransaction> RoTransactions { get; set; }
        public virtual ICollection<RoWorkflowFeedback> RoWorkflowFeedbacks { get; set; }
        public virtual ICollection<RoWorkflowServiceStep> RoWorkflowServiceSteps { get; set; }
        public virtual ICollection<RoWorkflowService> RoWorkflowServices { get; set; }
    }
}
