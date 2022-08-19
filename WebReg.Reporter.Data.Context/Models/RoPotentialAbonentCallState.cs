using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoPotentialAbonentCallState
    {
        public RoPotentialAbonentCallState()
        {
            RoPotentialAbonentCalls = new HashSet<RoPotentialAbonentCall>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentCall> RoPotentialAbonentCalls { get; set; }
    }
}
