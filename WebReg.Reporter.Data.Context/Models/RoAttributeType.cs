using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов атрибутов
    /// </summary>
    public partial class RoAttributeType
    {
        public RoAttributeType()
        {
            RoAttributes = new HashSet<RoAttribute>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int AttributeTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string AttributeTypeName { get; set; } = null!;

        public virtual ICollection<RoAttribute> RoAttributes { get; set; }
    }
}
