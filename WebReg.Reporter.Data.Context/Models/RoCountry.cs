using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица стран мира
    /// </summary>
    public partial class RoCountry
    {
        public RoCountry()
        {
            RoPeople = new HashSet<RoPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Цифровой код
        /// </summary>
        public string CountryId { get; set; } = null!;
        /// <summary>
        /// Буквенный код альфа-3
        /// </summary>
        public string Alpha3Id { get; set; } = null!;
        /// <summary>
        /// Буквенный код альфа-2
        /// </summary>
        public string Alpha2Id { get; set; } = null!;
        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; } = null!;
        /// <summary>
        /// Полное наименование
        /// </summary>
        public string FullName { get; set; } = null!;

        public virtual ICollection<RoPerson> RoPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
