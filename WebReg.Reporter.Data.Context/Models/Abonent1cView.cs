using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class Abonent1cView
    {
        public string? Id { get; set; }
        public string? Guid { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? Mobile { get; set; }
        public string? Pfr { get; set; }
        public int? Protocol { get; set; }
        public string? Host { get; set; }
        public DateOnly? EndTime { get; set; }
        public byte[]? Certificate { get; set; }
        public bool? SmsNotice { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? ShortName { get; set; }
        public int? CategoryId { get; set; }
    }
}
