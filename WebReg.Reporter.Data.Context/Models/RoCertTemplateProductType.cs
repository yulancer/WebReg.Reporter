using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица разрешенных шаблонов сертификата для типа программы
    /// </summary>
    public partial class RoCertTemplateProductType
    {
        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int CertTemplateId { get; set; }
        /// <summary>
        /// Тип программы
        /// </summary>
        public int ProductTypeId { get; set; }
        public bool IsDefault { get; set; }

        public virtual RoCertTemplate CertTemplate { get; set; } = null!;
        public virtual RoProductType ProductType { get; set; } = null!;
    }
}
