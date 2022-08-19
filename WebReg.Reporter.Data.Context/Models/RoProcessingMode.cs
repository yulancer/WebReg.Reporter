using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица режимов обработки
    /// </summary>
    public partial class RoProcessingMode
    {
        public RoProcessingMode()
        {
            RoProcessingProducts = new HashSet<RoProcessingProduct>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ModeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ModeName { get; set; } = null!;

        public virtual ICollection<RoProcessingProduct> RoProcessingProducts { get; set; }
    }
}
