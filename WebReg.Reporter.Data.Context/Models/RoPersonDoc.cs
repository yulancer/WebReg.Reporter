using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица документов физических лиц
    /// </summary>
    public partial class RoPersonDoc
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PersonDocId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public int DocId { get; set; }

        public virtual RoDoc Doc { get; set; } = null!;
        public virtual RoPerson Person { get; set; } = null!;
    }
}
