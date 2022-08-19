using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoPotentialAbonentRegNum
    {
        public int RegId { get; set; }
        public int PotentialAbonentId { get; set; }
        public string? RegNum { get; set; }
    }
}
