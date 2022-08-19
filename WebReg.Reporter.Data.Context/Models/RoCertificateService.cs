using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCertificateService
    {
        public RoCertificateService()
        {
            RoCertificateServiceSettings = new HashSet<RoCertificateServiceSetting>();
            RoCertificateServiceSteps = new HashSet<RoCertificateServiceStep>();
        }

        /// <summary>
        /// Ид. сертификата
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Тип сертивиса
        /// </summary>
        public int ServiceTypeId { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Ид. сервиса
        /// </summary>
        public int CertificateServiceId { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoServiceType ServiceType { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoCertificateServiceSetting> RoCertificateServiceSettings { get; set; }
        public virtual ICollection<RoCertificateServiceStep> RoCertificateServiceSteps { get; set; }
    }
}
