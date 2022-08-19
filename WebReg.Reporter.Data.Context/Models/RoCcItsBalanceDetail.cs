using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCcItsBalanceDetail
    {
        /// <summary>
        /// Идентификатор баланса
        /// </summary>
        public int BalanceId { get; set; }
        /// <summary>
        /// Идентификатор абонента
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Идентификатор тарифа по договору
        /// </summary>
        public int ContractTariffId { get; set; }
        /// <summary>
        /// Сумма вознаграждения
        /// </summary>
        public decimal SumReward { get; set; }
        /// <summary>
        /// Позиция по вознаграждению за ИТС
        /// </summary>
        public bool? IsIts { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoCcItsBalance Balance { get; set; } = null!;
        public virtual RoContractTariff ContractTariff { get; set; } = null!;
    }
}
