﻿using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoBillView
    {
        public int? BillId { get; set; }
        public string? ShortName { get; set; }
        public string? BillNumber { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal? BillTotalSum { get; set; }
        public decimal? BillNdsSum { get; set; }
        public decimal? BillPayedSum { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool? IsSent { get; set; }
        public string? ActNumber { get; set; }
        public DateTime? ActDocDate { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime? InvoiceDocDate { get; set; }
        public string? ActNdsNumber { get; set; }
        public DateTime? ActNdsDocDate { get; set; }
        public string? InvoiceNdsNumber { get; set; }
        public DateTime? InvoiceNdsDocDate { get; set; }
        public string? ProductNumber { get; set; }
        public DateTime? ProductDocDate { get; set; }
        public string? ProductndsNumber { get; set; }
        public DateTime? ProductndsDocDate { get; set; }
        public string? InvoiceReturnTypeName { get; set; }
        public DateTime? CancelTime { get; set; }
        public DateTime? BlockTime { get; set; }
        public string? Notice { get; set; }
    }
}
