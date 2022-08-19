using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица приложений документооборота
    /// </summary>
    public partial class RoWorkflowDocType
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int WorkflowDocTypeId { get; set; }
        /// <summary>
        /// Тип документооборота
        /// </summary>
        public int WorkflowTypeId { get; set; }
        /// <summary>
        /// Тип абонента
        /// </summary>
        public int AbonentTypeId { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public int DocTypeId { get; set; }
        /// <summary>
        /// Обязательный
        /// </summary>
        public bool Required { get; set; }

        public virtual RoAbonentType AbonentType { get; set; } = null!;
        public virtual RoDocType DocType { get; set; } = null!;
        public virtual RoWorkflowType WorkflowType { get; set; } = null!;
    }
}
