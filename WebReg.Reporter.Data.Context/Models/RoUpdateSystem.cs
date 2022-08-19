using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица систем обновлений
    /// </summary>
    public partial class RoUpdateSystem
    {
        public RoUpdateSystem()
        {
            RoGates = new HashSet<RoGate>();
            RoReflexTypeSystems = new HashSet<RoReflexTypeSystem>();
        }

        /// <summary>
        /// ИД записи
        /// </summary>
        public int SystemId { get; set; }
        /// <summary>
        /// Название системы
        /// </summary>
        public string SystemName { get; set; } = null!;
        /// <summary>
        /// Название системы
        /// </summary>
        public string SystemDescription { get; set; } = null!;

        public virtual ICollection<RoGate> RoGates { get; set; }
        public virtual ICollection<RoReflexTypeSystem> RoReflexTypeSystems { get; set; }
    }
}
