using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class ServerMemberView
    {
        public string? Id { get; set; }
        public Guid? Guid { get; set; }
        public string? Mobile { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Patronymic { get; set; }
        public string? Post { get; set; }
        public string? Snils { get; set; }
        public byte[]? Certificate { get; set; }
        public string? Skid { get; set; }
        public int? Type { get; set; }
    }
}
