using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица систем обновлений
    /// </summary>
    public partial class RoGateProductType
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public int GateProductTypeId { get; set; }
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual RoGate Gate { get; set; } = null!;
        public virtual RoOffice? Office { get; set; }
        public virtual RoProductType ProductType { get; set; } = null!;
    }
}
