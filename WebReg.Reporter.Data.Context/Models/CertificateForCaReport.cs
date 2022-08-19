﻿using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class CertificateForCaReport
    {
        public int? CertificateId { get; set; }
        public string? CommonName { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? CertTemplateName { get; set; }
        public int? CertificateTypeId { get; set; }
        public string? CertificateTypeName { get; set; }
        public int? ProductTypeId { get; set; }
        public string? ProductTypeName { get; set; }
        public Guid? ProductGuid { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public int? AbonentId { get; set; }
        public string? AgentName { get; set; }
        public int? AgentId { get; set; }
        public int? OfficeId { get; set; }
        public string? OfficeName { get; set; }
        public int? RegionId { get; set; }
        public string? RegionName { get; set; }
        public string? CompanyGroup { get; set; }
        public int? CaId { get; set; }
        public string? CaName { get; set; }
    }
}
