using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица подписей файла
    /// </summary>
    public partial class RoFileSignature
    {
        /// <summary>
        /// Файл
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// Подпись
        /// </summary>
        public int SignatureId { get; set; }
    }
}
