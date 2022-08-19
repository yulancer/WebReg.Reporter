using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица запросов на сертификат
    /// </summary>
    public partial class RoCertificateRequest
    {
        public RoCertificateRequest()
        {
            RoCertificateRequestSteps = new HashSet<RoCertificateRequestStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateRequestId { get; set; }
        /// <summary>
        /// Гуид
        /// </summary>
        public Guid CertificateRequestGuid { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Открытый ключ
        /// </summary>
        public string PublicKey { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string FullName { get; set; } = null!;
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }

        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoCertificateRequestStep> RoCertificateRequestSteps { get; set; }
    }
}
