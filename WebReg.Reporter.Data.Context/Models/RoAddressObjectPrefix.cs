using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица префиксов адреса
    /// </summary>
    public partial class RoAddressObjectPrefix
    {
        public RoAddressObjectPrefix()
        {
            RoAddressObjects = new HashSet<RoAddressObject>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int PrefixId { get; set; }
        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }
        /// <summary>
        /// Сокращение
        /// </summary>
        public string PrefixName { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string FullName { get; set; } = null!;

        public virtual RoAddressObjectLevel Level { get; set; } = null!;
        public virtual ICollection<RoAddressObject> RoAddressObjects { get; set; }
    }
}
