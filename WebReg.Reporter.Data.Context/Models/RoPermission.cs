using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица разрешений для ключа
    /// </summary>
    public partial class RoPermission
    {
        public RoPermission()
        {
            RoKeyPermissions = new HashSet<RoKeyPermission>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PermissionId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PermissionName { get; set; } = null!;
        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        public virtual RoPermissionType Type { get; set; } = null!;
        public virtual ICollection<RoKeyPermission> RoKeyPermissions { get; set; }
    }
}
