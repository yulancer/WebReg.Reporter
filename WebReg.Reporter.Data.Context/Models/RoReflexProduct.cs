using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица отражений для продукта
    /// </summary>
    public partial class RoReflexProduct
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// База
        /// </summary>
        public int ReflexId { get; set; }
        /// <summary>
        /// Тип базы
        /// </summary>
        public int ReflexTypeId { get; set; }

        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoReflex Reflex { get; set; } = null!;
        public virtual RoReflexType ReflexType { get; set; } = null!;
    }
}
