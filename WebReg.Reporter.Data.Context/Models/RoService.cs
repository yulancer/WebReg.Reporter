using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица услуг
    /// </summary>
    public partial class RoService
    {
        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public int ServiceId { get; set; }
        /// <summary>
        /// Ссылка на продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Ссылка на тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }
        /// <summary>
        /// Номер услуги
        /// </summary>
        public string? ServiceNumber { get; set; }
        /// <summary>
        /// Владелец ЭП
        /// </summary>
        public int? ProductPersonId { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoProductPerson? ProductPerson { get; set; }
        public virtual RoServiceType ServiceType { get; set; } = null!;
    }
}
