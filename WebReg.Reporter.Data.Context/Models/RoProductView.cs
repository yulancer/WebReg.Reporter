﻿using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoProductView
    {
        public int? ProductId { get; set; }
        public Guid? ProductGuid { get; set; }
        public int? AbonentId { get; set; }
        public string? ShortName { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? ProductTypeId { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? ContactPeople { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? CertTemplateName { get; set; }
        public DateTime? CertEndTime { get; set; }
        public DateTime? LicEndTime { get; set; }
        public DateTime? ActivationTime { get; set; }
        public string? ProductTypeName { get; set; }
        public string? UserName { get; set; }
        public int? LicenseTypeId { get; set; }
        public string? LicenseTypeName { get; set; }
        public string? TopAbon { get; set; }
        public int? AgentId { get; set; }
    }
}
