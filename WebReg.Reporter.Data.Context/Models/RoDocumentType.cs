using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов документов
    /// </summary>
    public partial class RoDocumentType
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DocumentTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string DocumentTypeName { get; set; } = null!;
    }
}
