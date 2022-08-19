using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица групп ролей
    /// </summary>
    public partial class RoRoleGroup
    {
        public RoRoleGroup()
        {
            RoRoles = new HashSet<RoRole>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int RoleGroupId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RoleGroupName { get; set; } = null!;

        public virtual ICollection<RoRole> RoRoles { get; set; }
    }
}
