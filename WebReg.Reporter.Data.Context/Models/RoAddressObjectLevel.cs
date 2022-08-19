using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица уровней адреса
    /// </summary>
    public partial class RoAddressObjectLevel
    {
        public RoAddressObjectLevel()
        {
            RoAddressObjectPrefixes = new HashSet<RoAddressObjectPrefix>();
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

        public virtual ICollection<RoAddressObjectPrefix> RoAddressObjectPrefixes { get; set; }
    }
}
