using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAo5BillView
    {
        public int? BillId { get; set; }
        public string? BillNumber { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal? BillTotalSum { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? InvoiceNdsNumber { get; set; }
        public DateTime? CancelTime { get; set; }
        public int? AgentId { get; set; }
    }
}
