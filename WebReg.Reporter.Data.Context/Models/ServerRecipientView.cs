using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class ServerRecipientView
    {
        public string? Id { get; set; }
        public Guid? Guid { get; set; }
        public int? Protocol { get; set; }
        public string? Recipient { get; set; }
        public string? Sos { get; set; }
        public string? Server { get; set; }
    }
}
