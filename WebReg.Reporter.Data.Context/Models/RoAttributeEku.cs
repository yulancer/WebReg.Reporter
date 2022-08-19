using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица расширений сертификата для атрибута
    /// </summary>
    public partial class RoAttributeEku
    {
        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>
        /// Расширение
        /// </summary>
        public int EkuId { get; set; }
        /// <summary>
        /// Опциональный ОИД
        /// </summary>
        public bool IsPrimary { get; set; }
        public bool IsOptional { get; set; }

        public virtual RoAttribute Attribute { get; set; } = null!;
        public virtual RoEku Eku { get; set; } = null!;
    }
}
