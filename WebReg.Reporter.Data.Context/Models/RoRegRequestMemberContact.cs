using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Контактные данные сотрудника
    /// </summary>
    public partial class RoRegRequestMemberContact
    {
        public RoRegRequestMemberContact()
        {
            RoRegRequestMemberContactUses = new HashSet<RoRegRequestMemberContactUse>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int RegRequestMemberId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Данные контакта
        /// </summary>
        public string ContactValue { get; set; } = null!;

        public virtual RoRegRequestMember RegRequestMember { get; set; } = null!;
        public virtual RoContactType Type { get; set; } = null!;
        public virtual ICollection<RoRegRequestMemberContactUse> RoRegRequestMemberContactUses { get; set; }
    }
}
