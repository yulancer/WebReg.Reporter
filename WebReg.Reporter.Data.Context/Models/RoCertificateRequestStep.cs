using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний продуктов
    /// </summary>
    public partial class RoCertificateRequestStep
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public int CertificateRequestId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Следующее состояние
        /// </summary>
        public int? NextStepId { get; set; }
        /// <summary>
        /// Ошибка
        /// </summary>
        public string? ErrorMsg { get; set; }
        /// <summary>
        /// Предыдущие состояние
        /// </summary>
        public int? PreviousStepId { get; set; }

        public virtual RoCertificateRequest CertificateRequest { get; set; } = null!;
        public virtual RoStep? NextStep { get; set; }
        public virtual RoStep? PreviousStep { get; set; }
        public virtual RoStep Step { get; set; } = null!;
    }
}
