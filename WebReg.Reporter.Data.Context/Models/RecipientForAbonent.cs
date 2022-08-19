using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Преставление получатели для абонентов
    /// </summary>
    public partial class RecipientForAbonent
    {
        public int? ProductId { get; set; }
        public Guid? ProductGuid { get; set; }
        public int? AbonentId { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? FullName { get; set; }
        public DateTime? CertEndTime { get; set; }
        public DateTime? LicenseEndTime { get; set; }
        public int? ProductTypeId { get; set; }
        public string? Manager { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? ContactPeople { get; set; }
        public DateTime? ConnectionTime { get; set; }
        public string? ProductTypeName { get; set; }
        public string? RecipientCode { get; set; }
        public int? ProtocolId { get; set; }
    }
}
