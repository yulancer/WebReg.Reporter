using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица полов
    /// </summary>
    public partial class RoGender
    {
        public RoGender()
        {
            RoPeople = new HashSet<RoPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int GenderId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string GenderName { get; set; } = null!;

        public virtual ICollection<RoPerson> RoPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
