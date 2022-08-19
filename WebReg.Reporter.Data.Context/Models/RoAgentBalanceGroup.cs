using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица групп продуктов сверки
    /// </summary>
    public partial class RoAgentBalanceGroup
    {
        public RoAgentBalanceGroup()
        {
            RoAgentBalanceBills = new HashSet<RoAgentBalanceBill>();
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoBalanceBuildTasks = new HashSet<RoBalanceBuildTask>();
        }

        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public int AgentBalanceGroupId { get; set; }
        /// <summary>
        /// Наименование группы
        /// </summary>
        public string AgentBalanceGroupName { get; set; } = null!;

        public virtual RoAgentBalanceProcessing RoAgentBalanceProcessing { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceBill> RoAgentBalanceBills { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoBalanceBuildTask> RoBalanceBuildTasks { get; set; }
    }
}
