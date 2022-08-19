using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAgentBalanceBill
    {
        /// <summary>
        /// Ид. баланса
        /// </summary>
        public int BalanceId { get; set; }
        /// <summary>
        /// Ид. счёта
        /// </summary>
        public int BillId { get; set; }
        /// <summary>
        /// Ид. группы
        /// </summary>
        public int BalanceGroupId { get; set; }

        public virtual RoAgentBalance Balance { get; set; } = null!;
        public virtual RoAgentBalanceGroup BalanceGroup { get; set; } = null!;
        public virtual RoSendedBill Bill { get; set; } = null!;
    }
}
