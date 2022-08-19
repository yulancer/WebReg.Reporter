using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class DelegateView
    {
        public Guid? Guid { get; set; }
        public string? Registrator { get; set; }
        public string? Office { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? DelegateName { get; set; }
        public string? AbonentName { get; set; }
        public int? CategoryId { get; set; }
        public string? Ruid { get; set; }
    }
}
