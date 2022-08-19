using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов хранилищ
    /// </summary>
    public partial class RoStorageType
    {
        public RoStorageType()
        {
            RoProductPeople = new HashSet<RoProductPerson>();
            RoProductPersonKeys = new HashSet<RoProductPersonKey>();
            RoProducts = new HashSet<RoProduct>();
            RoReflexRules = new HashSet<RoReflexRule>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
            RoRegRequests = new HashSet<RoRegRequest>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int StorageTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string StorageTypeName { get; set; } = null!;

        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoProductPersonKey> RoProductPersonKeys { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoReflexRule> RoReflexRules { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
    }
}
