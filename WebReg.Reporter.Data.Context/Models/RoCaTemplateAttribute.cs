using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица атрибутов шаблонов УЦ
    /// </summary>
    public partial class RoCaTemplateAttribute
    {
        /// <summary>
        /// Шаблон УЦ
        /// </summary>
        public int CaTemplateId { get; set; }
        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>
        /// Срок действия
        /// </summary>
        public int? Validity { get; set; }
        /// <summary>
        /// Ед. времени срока
        /// </summary>
        public int? ValidityUnitId { get; set; }

        public virtual RoAttribute Attribute { get; set; } = null!;
        public virtual RoCaTemplate CaTemplate { get; set; } = null!;
        public virtual RoUnit? ValidityUnit { get; set; }
    }
}
