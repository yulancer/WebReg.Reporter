using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCaServiceType
    {
        public RoCaServiceType()
        {
            RoCaServices = new HashSet<RoCaService>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaServiceTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CaServiceTypeName { get; set; } = null!;

        public virtual ICollection<RoCaService> RoCaServices { get; set; }
    }
}
