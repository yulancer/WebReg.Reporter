using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний услуг УЦ
    /// </summary>
    public partial class RoCertificateTariffStep
    {
        /// <summary>
        /// Услуга УЦ
        /// </summary>
        public int CertificateTariffId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoCertificateTariff CertificateTariff { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
