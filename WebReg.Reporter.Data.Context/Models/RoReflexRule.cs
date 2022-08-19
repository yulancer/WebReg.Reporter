using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица правил отражений
    /// </summary>
    public partial class RoReflexRule
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ReflexRuleId { get; set; }
        /// <summary>
        /// Отражение
        /// </summary>
        public int ReflexId { get; set; }
        /// <summary>
        /// Тип отражения
        /// </summary>
        public int ReflexTypeId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// Курьер
        /// </summary>
        public int? MessengerId { get; set; }
        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual RoMessenger? Messenger { get; set; }
        public virtual RoOffice? Office { get; set; }
        public virtual RoProductType? ProductType { get; set; }
        public virtual RoReflex Reflex { get; set; } = null!;
        public virtual RoReflexType ReflexType { get; set; } = null!;
        public virtual RoStorageType? StorageType { get; set; }
    }
}
