using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний услуг прайсов
    /// </summary>
    public partial class RoPriceTariffStep
    {
        /// <summary>
        /// Услуга
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Секция прайса
        /// </summary>
        public int SectionId { get; set; }

        public virtual RoPriceTariff RoPriceTariff { get; set; } = null!;
        public virtual RoPriceSection Section { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoTariff Tariff { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
