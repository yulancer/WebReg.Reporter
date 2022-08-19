using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMercuryRecipientView
    {
        public string? Id { get; set; }
        public Guid? ProductGuid { get; set; }
        public string? RecipientCode { get; set; }
        public int? ProtocolId { get; set; }
    }
}
