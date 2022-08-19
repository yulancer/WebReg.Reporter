using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Контактные данные сотрудников
    /// </summary>
    public partial class RoContactPerson
    {
        public RoContactPerson()
        {
            RoContactPersonUses = new HashSet<RoContactPersonUse>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactPersonId { get; set; }
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int ProductPersonId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Данные контакта
        /// </summary>
        public string ContactValue { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual RoProductPerson ProductPerson { get; set; } = null!;
        public virtual RoContactType Type { get; set; } = null!;
        public virtual ICollection<RoContactPersonUse> RoContactPersonUses { get; set; }
    }
}
