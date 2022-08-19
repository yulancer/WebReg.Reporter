using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoExtremumAoContractTariffView
    {
        public int? ContractId { get; set; }
        public int? FirstContractTariffId { get; set; }
        public int? LastContractTariffId { get; set; }
    }
}
