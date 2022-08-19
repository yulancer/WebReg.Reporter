using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица вознаграждений партнеров
    /// </summary>
    public partial class RoAgentReward
    {
        /// <summary>
        /// Тариф по договору
        /// </summary>
        public int ContractTariffId { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal PercentReward { get; set; }
        /// <summary>
        /// Сумма вознаграждения
        /// </summary>
        public decimal SumReward { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RewardId { get; set; }
        /// <summary>
        /// Премия
        /// </summary>
        public int? BonusId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoBonu? Bonus { get; set; }
        public virtual RoContractTariff ContractTariff { get; set; } = null!;
    }
}
