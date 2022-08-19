using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица отражений для типа продукта
    /// </summary>
    public partial class RoReflexMessenger
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
        /// Тип продукта
        /// </summary>
        public int MessengerId { get; set; }

        public virtual RoMessenger Messenger { get; set; } = null!;
        public virtual RoReflex Reflex { get; set; } = null!;
        public virtual RoReflexType ReflexType { get; set; } = null!;
    }
}
