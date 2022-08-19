using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица отражений для типа применения
    /// </summary>
    public partial class RoReflexUseType
    {
        /// <summary>
        /// Отражение
        /// </summary>
        public int ReflexId { get; set; }
        /// <summary>
        /// Тип отражения
        /// </summary>
        public int ReflexTypeId { get; set; }
        /// <summary>
        /// Тип применения
        /// </summary>
        public int UseTypeId { get; set; }

        public virtual RoReflex Reflex { get; set; } = null!;
        public virtual RoReflexType ReflexType { get; set; } = null!;
        public virtual RoUseType UseType { get; set; } = null!;
    }
}
