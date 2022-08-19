using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Использование контактов сотрудников
    /// </summary>
    public partial class RoContactPersonUse
    {
        /// <summary>
        /// Контакт сотрудника
        /// </summary>
        public int ContactPersonId { get; set; }
        /// <summary>
        /// Тип применения
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Основной
        /// </summary>
        public bool? Main { get; set; }

        public virtual RoContactPerson ContactPerson { get; set; } = null!;
        public virtual RoUseType Type { get; set; } = null!;
    }
}
