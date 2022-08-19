using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов продуктов
    /// </summary>
    public partial class RoPotentialAbonentProductType
    {
        public RoPotentialAbonentProductType()
        {
            RoPotentialAbonentStepTypes = new HashSet<RoPotentialAbonentStepType>();
        }

        /// <summary>
        /// ID типа продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Наименование типа продукта
        /// </summary>
        public string ProductTypeName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentStepType> RoPotentialAbonentStepTypes { get; set; }
    }
}
