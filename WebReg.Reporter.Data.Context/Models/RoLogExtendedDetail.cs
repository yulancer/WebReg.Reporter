using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoLogExtendedDetail
    {
        /// <summary>
        /// ID таблицы
        /// </summary>
        public int LogDetailId { get; set; }
        /// <summary>
        /// ID основного лога
        /// </summary>
        public int LogId { get; set; }
        /// <summary>
        /// Наименование колонки изменяемой таблицы
        /// </summary>
        public string FieldName { get; set; } = null!;
        /// <summary>
        /// Старое значение int
        /// </summary>
        public int? OldInt { get; set; }
        /// <summary>
        /// Старое значение string
        /// </summary>
        public string? OldString { get; set; }
        /// <summary>
        /// Старое значение bool
        /// </summary>
        public bool? OldBool { get; set; }
        /// <summary>
        /// Старое значение datetime
        /// </summary>
        public DateTime? OldDatetime { get; set; }
        /// <summary>
        /// Новое значение int
        /// </summary>
        public int? NewInt { get; set; }
        /// <summary>
        /// Новое значение string
        /// </summary>
        public string? NewString { get; set; }
        /// <summary>
        /// Новое значение bool
        /// </summary>
        public bool? NewBool { get; set; }
        /// <summary>
        /// Новое значение datetime
        /// </summary>
        public DateTime? NewDatetime { get; set; }

        public virtual RoLogExtended Log { get; set; } = null!;
    }
}
