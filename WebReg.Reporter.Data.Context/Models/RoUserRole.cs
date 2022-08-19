using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ролей пользователей
    /// </summary>
    public partial class RoUserRole
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual RoRole Role { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
