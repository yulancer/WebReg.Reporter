using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица услуг заявлений
    /// </summary>
    public partial class RoRegRequestTariff
    {
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Секция прайса
        /// </summary>
        public int? SectionId { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateOnly? EndDate { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateOnly? StartDate { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal? Price { get; set; }

        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoPriceTariff? RoPriceTariff { get; set; }
        public virtual RoPriceSection? Section { get; set; }
        public virtual RoTariff Tariff { get; set; } = null!;
    }
}
