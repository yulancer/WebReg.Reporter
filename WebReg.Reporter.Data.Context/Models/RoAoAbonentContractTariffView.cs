using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAoAbonentContractTariffView
    {
        public int? AbonentId { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? ShortName { get; set; }
        public int? ContractTariffId { get; set; }
        public DateOnly? InitialDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public int? TariffId { get; set; }
        public int? ContractId { get; set; }
        public int? AgentId { get; set; }
        public int? ParentId { get; set; }
        public string? RegionName { get; set; }
    }
}
