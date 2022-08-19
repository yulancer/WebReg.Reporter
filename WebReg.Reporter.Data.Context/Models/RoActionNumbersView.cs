using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoActionNumbersView
    {
        public int? AbonentId { get; set; }
        public int? AgentId { get; set; }
        public long? ActionNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
