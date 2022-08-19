using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица должностей
    /// </summary>
    public partial class RoPost
    {
        public RoPost()
        {
            RoAbonentPeople = new HashSet<RoAbonentPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
            RoUsers = new HashSet<RoUser>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PostId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PostName { get; set; } = null!;
        /// <summary>
        /// Флаг отображения
        /// </summary>
        public bool Display { get; set; }
        /// <summary>
        /// Наименование в родительном падеже
        /// </summary>
        public string? GenitiveName { get; set; }

        public virtual ICollection<RoAbonentPerson> RoAbonentPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
        public virtual ICollection<RoUser> RoUsers { get; set; }
    }
}
