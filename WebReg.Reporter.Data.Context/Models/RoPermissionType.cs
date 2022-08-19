using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов разрешений
    /// </summary>
    public partial class RoPermissionType
    {
        public RoPermissionType()
        {
            RoPermissions = new HashSet<RoPermission>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PermissionTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PermissionTypeName { get; set; } = null!;

        public virtual ICollection<RoPermission> RoPermissions { get; set; }
    }
}
