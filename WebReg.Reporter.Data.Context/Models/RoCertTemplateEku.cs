using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица расширений для шаблонов сертификатов
    /// </summary>
    public partial class RoCertTemplateEku
    {
        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int CertTemplateId { get; set; }
        /// <summary>
        /// Расширение
        /// </summary>
        public int EkuId { get; set; }
        /// <summary>
        /// Обязательное
        /// </summary>
        public bool Required { get; set; }

        public virtual RoCertTemplate CertTemplate { get; set; } = null!;
        public virtual RoEku Eku { get; set; } = null!;
    }
}
