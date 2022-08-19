using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoItsStringNumber
    {
        public string? RegistrationNumber { get; set; }
        public DateTime? ItsEndDate { get; set; }
        public string? ChildNumbers { get; set; }
        public DateTime? ItsEndDateNormal { get; set; }
    }
}
