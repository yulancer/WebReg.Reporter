using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCertificateServiceStep
    {
        /// <summary>
        /// Ид. сервиса
        /// </summary>
        public int CertificateServiceId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Время
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Ид
        /// </summary>
        public int CertificateServiceStepId { get; set; }

        public virtual RoCertificateService CertificateService { get; set; } = null!;
    }
}
