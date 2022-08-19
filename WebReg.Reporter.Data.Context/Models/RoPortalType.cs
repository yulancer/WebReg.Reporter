using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов личных кабинетов
    /// </summary>
    public partial class RoPortalType
    {
        public RoPortalType()
        {
            RoPortalAccounts = new HashSet<RoPortalAccount>();
            RoRegRequestAccounts = new HashSet<RoRegRequestAccount>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int PortalTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PortalTypeName { get; set; } = null!;

        public virtual ICollection<RoPortalAccount> RoPortalAccounts { get; set; }
        public virtual ICollection<RoRegRequestAccount> RoRegRequestAccounts { get; set; }
    }
}
