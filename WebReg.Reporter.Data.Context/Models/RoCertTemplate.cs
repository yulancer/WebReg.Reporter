using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица шаблонов сертификатов
    /// </summary>
    public partial class RoCertTemplate
    {
        public RoCertTemplate()
        {
            RoCertTemplateEkus = new HashSet<RoCertTemplateEku>();
            RoCertTemplateProductTypes = new HashSet<RoCertTemplateProductType>();
            RoKeys = new HashSet<RoKey>();
            RoOffices = new HashSet<RoOffice>();
            RoRegCertRequests = new HashSet<RoRegCertRequest>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CertTemplateId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CertTemplateName { get; set; } = null!;

        public virtual ICollection<RoCertTemplateEku> RoCertTemplateEkus { get; set; }
        public virtual ICollection<RoCertTemplateProductType> RoCertTemplateProductTypes { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoRegCertRequest> RoRegCertRequests { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
