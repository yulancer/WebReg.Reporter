using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Уровень сертификации партнера
    /// </summary>
    public partial class RoAgentLevelAuc
    {
        public RoAgentLevelAuc()
        {
            RoAgents = new HashSet<RoAgent>();
        }

        /// <summary>
        /// Идентификатор уровня
        /// </summary>
        public int LevelAucId { get; set; }
        /// <summary>
        /// Наименование уровня
        /// </summary>
        public string? LevelAucName { get; set; }
        /// <summary>
        /// Описание уровня
        /// </summary>
        public string? LevelAucDescription { get; set; }

        public virtual ICollection<RoAgent> RoAgents { get; set; }
    }
}
