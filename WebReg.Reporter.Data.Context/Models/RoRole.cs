using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ролей пользователей
    /// </summary>
    public partial class RoRole
    {
        public RoRole()
        {
            RoNewsVisibilities = new HashSet<RoNewsVisibility>();
            RoRoleModules = new HashSet<RoRoleModule>();
            RoUserRoles = new HashSet<RoUserRole>();
            RoUsers = new HashSet<RoUser>();
            AvailableRoles = new HashSet<RoRole>();
            Roles = new HashSet<RoRole>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RoleName { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public int RoleGroupId { get; set; }
        /// <summary>
        /// Публичное наименование роли
        /// </summary>
        public string? RolePublicName { get; set; }

        public virtual RoRoleGroup RoleGroup { get; set; } = null!;
        public virtual ICollection<RoNewsVisibility> RoNewsVisibilities { get; set; }
        public virtual ICollection<RoRoleModule> RoRoleModules { get; set; }
        public virtual ICollection<RoUserRole> RoUserRoles { get; set; }
        public virtual ICollection<RoUser> RoUsers { get; set; }

        public virtual ICollection<RoRole> AvailableRoles { get; set; }
        public virtual ICollection<RoRole> Roles { get; set; }
    }
}
