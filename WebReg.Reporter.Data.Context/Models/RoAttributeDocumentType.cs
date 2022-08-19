using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица документов требуемых для атрибута
    /// </summary>
    public partial class RoAttributeDocumentType
    {
        /// <summary>
        /// ИД атрибута
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>
        /// ИД типа документа
        /// </summary>
        public int DocTypeId { get; set; }
        /// <summary>
        /// Документ требуется только к доверенности
        /// </summary>
        public bool OnlyForProxy { get; set; }

        public virtual RoAttribute Attribute { get; set; } = null!;
        public virtual RoDocType DocType { get; set; } = null!;
    }
}
