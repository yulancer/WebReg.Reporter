using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Состояния заявки на изменение позиции сверки
    /// </summary>
    public partial class RoAgentBalanceDetailChangeRequestStep
    {
        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int BalanceDetailChangeRequestId { get; set; }
        /// <summary>
        /// Время смены состояния заявки
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Состояние заявки
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь, сменивший состояние заявки
        /// </summary>
        public int UserId { get; set; }

        public virtual RoAgentBalanceDetailChangeRequest BalanceDetailChangeRequest { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
