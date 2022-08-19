using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица со словарем реквизитов
    /// </summary>
    public partial class RoPropDict
    {
        /// <summary>
        /// Тип
        /// </summary>
        public int PropTypeId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string PropValue { get; set; } = null!;

        public virtual RoPropType PropType { get; set; } = null!;
    }
}
