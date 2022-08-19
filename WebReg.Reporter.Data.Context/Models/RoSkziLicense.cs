using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoSkziLicense
    {
        public int LicenseId { get; set; }
        public string LicenseNumber { get; set; } = null!;
        public int? AgentId { get; set; }
        public int? BillId { get; set; }
        public int? MerchandiseId { get; set; }
        public int? MerchandiseBillId { get; set; }
        public int? LicenseBlankId { get; set; }

        public virtual RoAgent? Agent { get; set; }
        public virtual RoSendedBill? Bill { get; set; }
        public virtual RoFile? LicenseBlank { get; set; }
        public virtual RoMerchandise? Merchandise { get; set; }
        public virtual RoMerchandiseBill? MerchandiseBill { get; set; }
    }
}
