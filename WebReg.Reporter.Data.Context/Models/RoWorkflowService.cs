using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица для описания доп. услуг, связанных с документооборотом
    /// </summary>
    public partial class RoWorkflowService
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ServiceId { get; set; }
        /// <summary>
        /// Ссылка на документооборот
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Ссылка на тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }
        /// <summary>
        /// Ссылка на состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid? GateId { get; set; }
        /// <summary>
        /// Адрес ответа
        /// </summary>
        public string? CallbackAddress { get; set; }

        public virtual RoGate? Gate { get; set; }
        public virtual RoServiceType ServiceType { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoWorkflow Workflow { get; set; } = null!;
    }
}
