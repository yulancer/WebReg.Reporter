using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица подразделений
    /// </summary>
    public partial class RoOrgUnit
    {
        public RoOrgUnit()
        {
            RoAbonentPeople = new HashSet<RoAbonentPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OrgUnitId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string OrgUnitName { get; set; } = null!;
        /// <summary>
        /// Флаг отображения
        /// </summary>
        public bool Display { get; set; }

        public virtual ICollection<RoAbonentPerson> RoAbonentPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
