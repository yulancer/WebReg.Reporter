using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление с датами регистрации получателей у абонентов
    /// </summary>
    public partial class AbonentRecipientRegDate
    {
        public int? AbonentId { get; set; }
        public int? RegionId { get; set; }
        public string? RecipientCode { get; set; }
        public int? AbonentTypeId { get; set; }
        public int? ProtocolId { get; set; }
        public DateTime? RegDate { get; set; }
    }
}
