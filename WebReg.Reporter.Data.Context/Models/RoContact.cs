using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Контактные данные
    /// </summary>
    public partial class RoContact
    {
        public RoContact()
        {
            RoContactUses = new HashSet<RoContactUse>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
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

        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoContactType Type { get; set; } = null!;
        public virtual ICollection<RoContactUse> RoContactUses { get; set; }
    }
}
