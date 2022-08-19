using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица систем налогообложения
    /// </summary>
    public partial class RoTaxSystem
    {
        public RoTaxSystem()
        {
            RoProducts = new HashSet<RoProduct>();
        }

        /// <summary>
        /// Идентификатор системы налогообложения
        /// </summary>
        public int TaxSystemId { get; set; }
        /// <summary>
        /// Название системы налогообложения
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Обозначение системы налогообложения
        /// </summary>
        public string Alias { get; set; } = null!;

        public virtual ICollection<RoProduct> RoProducts { get; set; }
    }
}
