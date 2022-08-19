using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица расширений услуг продукта
    /// </summary>
    public partial class RoContractTariffExtension
    {
        /// <summary>
        /// Расширение
        /// </summary>
        public int ExtensionId { get; set; }
        /// <summary>
        /// Главная услуга
        /// </summary>
        public int ContractTariffId { get; set; }

        public virtual RoContractTariff ContractTariff { get; set; } = null!;
        public virtual RoContractTariff Extension { get; set; } = null!;
    }
}
