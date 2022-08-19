using System;
using System.Collections.Generic;
using System.Net;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMercuryOfficeView
    {
        public Guid? MercuryGuid { get; set; }
        public string? Ruid { get; set; }
        public string? OfficeName { get; set; }
        public string? AgentName { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? RnsPfr { get; set; }
        public string? ShortName { get; set; }
        public int? ProtocolId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Mobile { get; set; }
        public string? DomainIn { get; set; }
        public IPAddress? IpAddress { get; set; }
        public DateTime? EndTime { get; set; }
        public DateOnly? DateFixed { get; set; }
        public string? ProviderName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? TypeId { get; set; }
    }
}
