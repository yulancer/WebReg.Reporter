using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица видов документов
    /// </summary>
    public partial class RoDocType
    {
        public RoDocType()
        {
            RoAttributeDocumentTypes = new HashSet<RoAttributeDocumentType>();
            RoDocs = new HashSet<RoDoc>();
            RoWorkflowDocTypes = new HashSet<RoWorkflowDocType>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int DocTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string DocTypeName { get; set; } = null!;
        /// <summary>
        /// Псевдоним
        /// </summary>
        public string? DocTypeAlias { get; set; }

        public virtual ICollection<RoAttributeDocumentType> RoAttributeDocumentTypes { get; set; }
        public virtual ICollection<RoDoc> RoDocs { get; set; }
        public virtual ICollection<RoWorkflowDocType> RoWorkflowDocTypes { get; set; }
    }
}
