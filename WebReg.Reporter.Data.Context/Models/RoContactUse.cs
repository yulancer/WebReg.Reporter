using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Использование контактов
    /// </summary>
    public partial class RoContactUse
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

        public virtual RoContact Contact { get; set; } = null!;
        public virtual RoUseType Type { get; set; } = null!;
    }
}
