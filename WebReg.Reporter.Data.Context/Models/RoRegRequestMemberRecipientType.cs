using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoRegRequestMemberRecipientType
    {
        public int MemberId { get; set; }
        public int ProtocolId { get; set; }
        public bool? IsEncryptor { get; set; }

        public virtual RoRegRequestMember Member { get; set; } = null!;
        public virtual RoProtocol Protocol { get; set; } = null!;
    }
}
