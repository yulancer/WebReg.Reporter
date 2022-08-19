using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица связи ролей с модулями
    /// </summary>
    public partial class RoRoleModule
    {
        /// <summary>
        /// Роль
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Модуль
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Уровень доступа
        /// </summary>
        public int AccessLevelId { get; set; }

        public virtual RoAccessLevel AccessLevel { get; set; } = null!;
        public virtual RoModule Module { get; set; } = null!;
        public virtual RoRole Role { get; set; } = null!;
    }
}
