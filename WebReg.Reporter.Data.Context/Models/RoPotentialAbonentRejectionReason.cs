using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoPotentialAbonentRejectionReason
    {
        public RoPotentialAbonentRejectionReason()
        {
            RoPotentialAbonentCalls = new HashSet<RoPotentialAbonentCall>();
        }

        public int ReasonId { get; set; }
        public string ReasonName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentCall> RoPotentialAbonentCalls { get; set; }
    }
}
