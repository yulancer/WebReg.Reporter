using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица квалификаций подписи
    /// </summary>
    public partial class RoSignQualification
    {
        public RoSignQualification()
        {
            RoProductPeople = new HashSet<RoProductPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int SignQualificationId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string SignQualificationName { get; set; } = null!;

        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
