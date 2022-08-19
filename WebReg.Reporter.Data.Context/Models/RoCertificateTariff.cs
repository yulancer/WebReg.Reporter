using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица услуг УЦ
    /// </summary>
    public partial class RoCertificateTariff
    {
        public RoCertificateTariff()
        {
            RoCertificateTariffSteps = new HashSet<RoCertificateTariffStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CertificateTariffId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Процент скидки
        /// </summary>
        public decimal PercentDiscount { get; set; }
        /// <summary>
        /// Сумма скидки
        /// </summary>
        public decimal DiscountSum { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoCertificateTariffStep> RoCertificateTariffSteps { get; set; }
    }
}
