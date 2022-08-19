using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// История цен
    /// </summary>
    public partial class RoPriceTrend
    {
        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }
        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime InitialTime { get; set; }
        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Затраты
        /// </summary>
        public decimal? Cost { get; set; }

        public virtual RoPriceTariff RoPriceTariff { get; set; } = null!;
        public virtual RoPriceSection Section { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
    }
}
