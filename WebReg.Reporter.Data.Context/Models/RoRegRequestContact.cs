using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Контактные данные заявления
    /// </summary>
    public partial class RoRegRequestContact
    {
        public RoRegRequestContact()
        {
            RoRegRequestContactUses = new HashSet<RoRegRequestContactUse>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Данные контакта
        /// </summary>
        public string ContactValue { get; set; } = null!;

        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoContactType Type { get; set; } = null!;
        public virtual ICollection<RoRegRequestContactUse> RoRegRequestContactUses { get; set; }
    }
}
