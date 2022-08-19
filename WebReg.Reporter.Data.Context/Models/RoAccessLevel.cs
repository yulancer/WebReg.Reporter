using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица уровней доступа
    /// </summary>
    public partial class RoAccessLevel
    {
        public RoAccessLevel()
        {
            RoRoleModules = new HashSet<RoRoleModule>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int AccessLevelId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string AccessLevelName { get; set; } = null!;
        /// <summary>
        /// Приоритет операции
        /// </summary>
        public int? LevelPriority { get; set; }

        public virtual ICollection<RoRoleModule> RoRoleModules { get; set; }
    }
}
