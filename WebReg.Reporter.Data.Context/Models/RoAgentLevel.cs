using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица уровней партнеров
    /// </summary>
    public partial class RoAgentLevel
    {
        public RoAgentLevel()
        {
            RoAgentSchemes = new HashSet<RoAgentScheme>();
            RoAgents = new HashSet<RoAgent>();
            RoNewsVisibilities = new HashSet<RoNewsVisibility>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int LevelId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string LevelName { get; set; } = null!;
        /// <summary>
        /// Примечание
        /// </summary>
        public string? LevelNote { get; set; }

        public virtual ICollection<RoAgentScheme> RoAgentSchemes { get; set; }
        public virtual ICollection<RoAgent> RoAgents { get; set; }
        public virtual ICollection<RoNewsVisibility> RoNewsVisibilities { get; set; }
    }
}
