using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMercuryExternalView
    {
        public int? MercuryId { get; set; }
        public Guid? MercuryGuid { get; set; }
        public string? ShortName { get; set; }
        public string? Inn { get; set; }
        public string? RnsPfr { get; set; }
        public int? ProtocolId { get; set; }
        public string? RecipientCode { get; set; }
        public string? Kpp { get; set; }
        public string? PrefixSos { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public byte[]? CerData { get; set; }
        public string? Mobile { get; set; }
        public string? RnsFss { get; set; }
        public string? SubjectKeyId { get; set; }
        public Guid? OfficeGuid { get; set; }
    }
}
