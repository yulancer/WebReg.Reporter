using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов услуг.
    /// </summary>
    public partial class RoServiceType
    {
        public RoServiceType()
        {
            RoCertificateServices = new HashSet<RoCertificateService>();
            RoRegRequestServices = new HashSet<RoRegRequestService>();
            RoServiceBalanceDetails = new HashSet<RoServiceBalanceDetail>();
            RoServices = new HashSet<RoService>();
            RoWorkflowServices = new HashSet<RoWorkflowService>();
        }

        /// <summary>
        /// Идентификатор типа услуги
        /// </summary>
        public int ServiceTypeId { get; set; }
        /// <summary>
        /// Наименование типа услуги
        /// </summary>
        public string ServiceTypeName { get; set; } = null!;
        /// <summary>
        /// Режим
        /// </summary>
        public int ServiceModeId { get; set; }

        public virtual RoServiceMode ServiceMode { get; set; } = null!;
        public virtual ICollection<RoCertificateService> RoCertificateServices { get; set; }
        public virtual ICollection<RoRegRequestService> RoRegRequestServices { get; set; }
        public virtual ICollection<RoServiceBalanceDetail> RoServiceBalanceDetails { get; set; }
        public virtual ICollection<RoService> RoServices { get; set; }
        public virtual ICollection<RoWorkflowService> RoWorkflowServices { get; set; }
    }
}
