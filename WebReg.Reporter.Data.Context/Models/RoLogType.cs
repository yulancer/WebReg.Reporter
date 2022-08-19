using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов лога
    /// </summary>
    public partial class RoLogType
    {
        public RoLogType()
        {
            RoLogExtendeds = new HashSet<RoLogExtended>();
            RoLogV2s = new HashSet<RoLogV2>();
            RoLogs = new HashSet<RoLog>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int LogTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string LogTypeName { get; set; } = null!;

        public virtual ICollection<RoLogExtended> RoLogExtendeds { get; set; }
        public virtual ICollection<RoLogV2> RoLogV2s { get; set; }
        public virtual ICollection<RoLog> RoLogs { get; set; }
    }
}
