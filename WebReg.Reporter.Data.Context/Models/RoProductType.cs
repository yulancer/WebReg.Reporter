using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов продуктов
    /// </summary>
    public partial class RoProductType
    {
        public RoProductType()
        {
            RoAbonentCounts = new HashSet<RoAbonentCount>();
            RoAgentMerchandises = new HashSet<RoAgentMerchandise>();
            RoAgentSchemes = new HashSet<RoAgentScheme>();
            RoCaProductTypes = new HashSet<RoCaProductType>();
            RoCertTemplateProductTypes = new HashSet<RoCertTemplateProductType>();
            RoCheckingSchemes = new HashSet<RoCheckingScheme>();
            RoCompanyGroups = new HashSet<RoCompanyGroup>();
            RoGateProductTypes = new HashSet<RoGateProductType>();
            RoModules = new HashSet<RoModule>();
            RoNewsVisibilities = new HashSet<RoNewsVisibility>();
            RoPriceSchemes = new HashSet<RoPriceScheme>();
            RoProductPeople = new HashSet<RoProductPerson>();
            RoProducts = new HashSet<RoProduct>();
            RoReflexProductTypes = new HashSet<RoReflexProductType>();
            RoReflexRules = new HashSet<RoReflexRule>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoRejectedRegRequests = new HashSet<RoRejectedRegRequest>();
            RoReports = new HashSet<RoReport>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Кодовое имя
        /// </summary>
        public string CodeName { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string ProductTypeName { get; set; } = null!;
        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid ProductTypeGuid { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual ICollection<RoAbonentCount> RoAbonentCounts { get; set; }
        public virtual ICollection<RoAgentMerchandise> RoAgentMerchandises { get; set; }
        public virtual ICollection<RoAgentScheme> RoAgentSchemes { get; set; }
        public virtual ICollection<RoCaProductType> RoCaProductTypes { get; set; }
        public virtual ICollection<RoCertTemplateProductType> RoCertTemplateProductTypes { get; set; }
        public virtual ICollection<RoCheckingScheme> RoCheckingSchemes { get; set; }
        public virtual ICollection<RoCompanyGroup> RoCompanyGroups { get; set; }
        public virtual ICollection<RoGateProductType> RoGateProductTypes { get; set; }
        public virtual ICollection<RoModule> RoModules { get; set; }
        public virtual ICollection<RoNewsVisibility> RoNewsVisibilities { get; set; }
        public virtual ICollection<RoPriceScheme> RoPriceSchemes { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoReflexProductType> RoReflexProductTypes { get; set; }
        public virtual ICollection<RoReflexRule> RoReflexRules { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoRejectedRegRequest> RoRejectedRegRequests { get; set; }
        public virtual ICollection<RoReport> RoReports { get; set; }
    }
}
