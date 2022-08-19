using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица схемы проверок
    /// </summary>
    public partial class RoCheckingScheme
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SchemeId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Тип проверки
        /// </summary>
        public int CheckingTypeId { get; set; }
        /// <summary>
        /// Режим проверки
        /// </summary>
        public int CheckingModeId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual RoCheckingMode CheckingMode { get; set; } = null!;
        public virtual RoCheckingType CheckingType { get; set; } = null!;
        public virtual RoOffice? Office { get; set; }
        public virtual RoProductType ProductType { get; set; } = null!;
    }
}
