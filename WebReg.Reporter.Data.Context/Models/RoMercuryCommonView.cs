using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMercuryCommonView
    {
        public Guid? MercuryGuid { get; set; }
        public string? ShortName { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? RnsPfr { get; set; }
        public string? AccountIn { get; set; }
        public string? PasswordIn { get; set; }
        public string? IrucAccount { get; set; }
        public string? IrucPassword { get; set; }
        public string? DomainSoed { get; set; }
        public string? PrefixSos { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public int? AbonentTypeId { get; set; }
        public int? ProtocolId { get; set; }
        public bool? HardCodeSos { get; set; }
        public int? MercuryId { get; set; }
        public string? DefaultPrefixSos { get; set; }
        public int? CategoryId { get; set; }
        public string? RnsFss { get; set; }
    }
}
