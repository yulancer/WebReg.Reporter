using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// План подключений абонентов
    /// </summary>
    public partial class RoPlan
    {
        public RoPlan()
        {
            RoPlanDetails = new HashSet<RoPlanDetail>();
            Schemes = new HashSet<RoAgentScheme>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PlanId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PlanName { get; set; } = null!;

        public virtual ICollection<RoPlanDetail> RoPlanDetails { get; set; }

        public virtual ICollection<RoAgentScheme> Schemes { get; set; }
    }
}
