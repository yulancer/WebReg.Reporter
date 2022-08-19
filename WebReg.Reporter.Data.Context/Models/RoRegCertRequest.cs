using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица регистрации запросов на сертификаты
    /// </summary>
    public partial class RoRegCertRequest
    {
        public RoRegCertRequest()
        {
            RoRegCertRequestSteps = new HashSet<RoRegCertRequestStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegCertRequestId { get; set; }
        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int CertRequestId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Открытый ключ
        /// </summary>
        public string PublicKey { get; set; } = null!;
        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string? SubjectKeyId { get; set; }
        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int CertTemplateId { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RequestId { get; set; }
        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string? PackId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoCertTemplate CertTemplate { get; set; } = null!;
        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual RoWorkflow Workflow { get; set; } = null!;
        public virtual ICollection<RoRegCertRequestStep> RoRegCertRequestSteps { get; set; }
    }
}
