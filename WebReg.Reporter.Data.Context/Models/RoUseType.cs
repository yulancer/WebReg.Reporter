using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Тип применения
    /// </summary>
    public partial class RoUseType
    {
        public RoUseType()
        {
            RoContactPersonUses = new HashSet<RoContactPersonUse>();
            RoContactUses = new HashSet<RoContactUse>();
            RoReflexUseTypes = new HashSet<RoReflexUseType>();
            RoRegRequestContactUses = new HashSet<RoRegRequestContactUse>();
            RoRegRequestMemberContactUses = new HashSet<RoRegRequestMemberContactUse>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int UseTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string UseTypeName { get; set; } = null!;

        public virtual ICollection<RoContactPersonUse> RoContactPersonUses { get; set; }
        public virtual ICollection<RoContactUse> RoContactUses { get; set; }
        public virtual ICollection<RoReflexUseType> RoReflexUseTypes { get; set; }
        public virtual ICollection<RoRegRequestContactUse> RoRegRequestContactUses { get; set; }
        public virtual ICollection<RoRegRequestMemberContactUse> RoRegRequestMemberContactUses { get; set; }
    }
}
