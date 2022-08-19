using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoItsProcessedFileHistory
    {
        /// <summary>
        /// Идентификатор файла
        /// </summary>
        public int ItsProcessedFileHistoryId { get; set; }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; } = null!;
        /// <summary>
        /// Дата обработки файла
        /// </summary>
        public DateTime ProcessedDate { get; set; }
    }
}
