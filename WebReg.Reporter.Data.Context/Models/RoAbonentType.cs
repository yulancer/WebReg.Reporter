using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов абонентов
    /// </summary>
    public partial class RoAbonentType
    {
        public RoAbonentType()
        {
            RoAbonentImportTasks = new HashSet<RoAbonentImportTask>();
            RoAbonents = new HashSet<RoAbonent>();
            RoKcrIssues = new HashSet<RoKcrIssue>();
            RoPotentialAbonents = new HashSet<RoPotentialAbonent>();
            RoProducts = new HashSet<RoProduct>();
            RoRegBankRequests = new HashSet<RoRegBankRequest>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoWorkflowDocTypes = new HashSet<RoWorkflowDocType>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int AbonentTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string AbonentTypeName { get; set; } = null!;
        /// <summary>
        /// Тип ИРУЦ
        /// </summary>
        public string IrucTitle { get; set; } = null!;

        public virtual ICollection<RoAbonentImportTask> RoAbonentImportTasks { get; set; }
        public virtual ICollection<RoAbonent> RoAbonents { get; set; }
        public virtual ICollection<RoKcrIssue> RoKcrIssues { get; set; }
        public virtual ICollection<RoPotentialAbonent> RoPotentialAbonents { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoRegBankRequest> RoRegBankRequests { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoWorkflowDocType> RoWorkflowDocTypes { get; set; }
    }
}
