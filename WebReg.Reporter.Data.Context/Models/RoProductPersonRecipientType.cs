using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoProductPersonRecipientType
    {
        public int ProductPersonId { get; set; }
        public int ProtocolId { get; set; }
        public bool? IsEncryptor { get; set; }

        public virtual RoProductPerson ProductPerson { get; set; } = null!;
        public virtual RoProtocol Protocol { get; set; } = null!;
    }
}
