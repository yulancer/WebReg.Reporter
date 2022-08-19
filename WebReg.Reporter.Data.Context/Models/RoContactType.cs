using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Тип контактных данных
    /// </summary>
    public partial class RoContactType
    {
        public RoContactType()
        {
            RoContactPeople = new HashSet<RoContactPerson>();
            RoContacts = new HashSet<RoContact>();
            RoDssUsers = new HashSet<RoDssUser>();
            RoRegRequestContacts = new HashSet<RoRegRequestContact>();
            RoRegRequestMemberContacts = new HashSet<RoRegRequestMemberContact>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ContactTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ContactTypeName { get; set; } = null!;

        public virtual ICollection<RoContactPerson> RoContactPeople { get; set; }
        public virtual ICollection<RoContact> RoContacts { get; set; }
        public virtual ICollection<RoDssUser> RoDssUsers { get; set; }
        public virtual ICollection<RoRegRequestContact> RoRegRequestContacts { get; set; }
        public virtual ICollection<RoRegRequestMemberContact> RoRegRequestMemberContacts { get; set; }
    }
}
