using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class ServerAbonentView
    {
        public Guid? Guid { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? Pfr { get; set; }
        public string? Ogrn { get; set; }
        public string? Fss { get; set; }
        public string? Name { get; set; }
        public Guid? RegGuid { get; set; }
        public string? Registrator { get; set; }
        public string? Partner { get; set; }
        public DateOnly? Expiry { get; set; }
        public int? Type { get; set; }
        public int? StorageTypeId { get; set; }
    }
}
