using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoChildAgentViewAndAbonent
    {
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public int? AbonentId { get; set; }
        public string? ShortName { get; set; }
        public int? AgentId { get; set; }
        public string? AgentName { get; set; }
        public int? LevelId { get; set; }
        public int? SaleCenterId { get; set; }
        public string? SaleCenterName { get; set; }
        public int? CompetentionCenterId { get; set; }
        public string? CompetentionCenterName { get; set; }
    }
}
