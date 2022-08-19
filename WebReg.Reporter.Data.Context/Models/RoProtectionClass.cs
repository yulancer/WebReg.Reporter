using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица классов защиты
    /// </summary>
    public partial class RoProtectionClass
    {
        public RoProtectionClass()
        {
            RoKeys = new HashSet<RoKey>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ProtectionClassId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ProtectionClassName { get; set; } = null!;
        /// <summary>
        /// Объектный идентификатор
        /// </summary>
        public string PolicyOid { get; set; } = null!;

        public virtual ICollection<RoKey> RoKeys { get; set; }
    }
}
