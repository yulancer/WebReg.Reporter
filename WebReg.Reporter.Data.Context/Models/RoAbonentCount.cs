using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица подсчета абонентов
    /// </summary>
    public partial class RoAbonentCount
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int CountRecordId { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }
        /// <summary>
        /// Число активных в начале периода
        /// </summary>
        public int ActiveAtStart { get; set; }
        /// <summary>
        /// Число активных в конце периода
        /// </summary>
        public int ActiveAtEnd { get; set; }
        /// <summary>
        /// Число новых подключившихся в период
        /// </summary>
        public int Connected { get; set; }
        /// <summary>
        /// Число отключившихся в период
        /// </summary>
        public int Disconnected { get; set; }
        /// <summary>
        /// Число абонентов с истекшими тарифами
        /// </summary>
        public int? Expired { get; set; }

        public virtual RoOffice? Office { get; set; }
        public virtual RoProductType? ProductType { get; set; }
    }
}
