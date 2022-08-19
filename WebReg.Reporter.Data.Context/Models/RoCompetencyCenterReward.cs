using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCompetencyCenterReward
    {
        public int? AgentId { get; set; }
        public decimal? PercentReward { get; set; }
        public int? ContractTariffId { get; set; }
    }
}
