using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ценовых схем
    /// </summary>
    public partial class RoPriceScheme
    {
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Тарифная зона
        /// </summary>
        public int TariffZoneId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Центр компетенции
        /// </summary>
        public int? CompetenceCenterId { get; set; }
        /// <summary>
        /// Ведущий партнер
        /// </summary>
        public int? LeadOfficeId { get; set; }

        public virtual RoOffice? CompetenceCenter { get; set; }
        public virtual RoOffice? LeadOffice { get; set; }
        public virtual RoProductType ProductType { get; set; } = null!;
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoTariffZone TariffZone { get; set; } = null!;
    }
}
