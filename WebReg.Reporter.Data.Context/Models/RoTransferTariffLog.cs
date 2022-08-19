using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица логирования переноса лицензий
    /// </summary>
    public partial class RoTransferTariffLog
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransferTariffId { get; set; }
        /// <summary>
        /// Лог переноса продукта
        /// </summary>
        public int ProductTransferId { get; set; }
        /// <summary>
        /// Лицензия
        /// </summary>
        public int ContractTariffId { get; set; }
        /// <summary>
        /// Предыдущая лицензия
        /// </summary>
        public int PreviousContractTariffId { get; set; }

        public virtual RoContractTariff ContractTariff { get; set; } = null!;
        public virtual RoContractTariff PreviousContractTariff { get; set; } = null!;
        public virtual RoProductTransferLog ProductTransfer { get; set; } = null!;
    }
}
