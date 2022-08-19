using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Ежемесячные сверки между партнером и офисами БИТ
    /// </summary>
    public partial class RoAgentBalanceOffice
    {
        /// <summary>
        /// Идентификатор сверки по офисам
        /// </summary>
        public int BalanceOfficeId { get; set; }
        /// <summary>
        /// Баланс
        /// </summary>
        public int BalanceId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Дата одобрения сверки офисом
        /// </summary>
        public DateTime? OfficeAcceptDate { get; set; }

        public virtual RoAgentBalance Balance { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
    }
}
