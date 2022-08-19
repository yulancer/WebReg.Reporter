using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class ProductDataTemp
    {
        public int ProductId { get; set; }
        public string TariffName { get; set; } = null!;
        public DateTime? TariffEndDate { get; set; }
    }
}
