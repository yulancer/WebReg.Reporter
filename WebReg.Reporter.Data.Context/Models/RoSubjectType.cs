using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов субъектов документооборота
    /// </summary>
    public partial class RoSubjectType
    {
        public RoSubjectType()
        {
            RoTransactionRecipientTypes = new HashSet<RoTransaction>();
            RoTransactionSenderTypes = new HashSet<RoTransaction>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SubjectTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string SubjectTypeName { get; set; } = null!;
        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }

        public virtual RoWorkflowType WorkflowType { get; set; } = null!;
        public virtual ICollection<RoTransaction> RoTransactionRecipientTypes { get; set; }
        public virtual ICollection<RoTransaction> RoTransactionSenderTypes { get; set; }
    }
}
