using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Использование контактов сотрудников
    /// </summary>
    public partial class RoRegRequestMemberContactUse
    {
        /// <summary>
        /// Контакт
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Тип применения
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Основной
        /// </summary>
        public bool? Main { get; set; }

        public virtual RoRegRequestMemberContact Contact { get; set; } = null!;
        public virtual RoUseType Type { get; set; } = null!;
    }
}
