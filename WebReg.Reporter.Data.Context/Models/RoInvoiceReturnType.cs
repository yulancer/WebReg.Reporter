using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoInvoiceReturnType
    {
        public RoInvoiceReturnType()
        {
            RoSendedBills = new HashSet<RoSendedBill>();
        }

        public int InvoiceReturnTypeId { get; set; }
        public string InvoiceReturnTypeName { get; set; } = null!;

        public virtual ICollection<RoSendedBill> RoSendedBills { get; set; }
    }
}
