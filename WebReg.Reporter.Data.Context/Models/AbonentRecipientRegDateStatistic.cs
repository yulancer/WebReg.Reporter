using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление со статистикой подключений абонентов по получателям
    /// </summary>
    public partial class AbonentRecipientRegDateStatistic
    {
        public double? Y { get; set; }
        public double? M { get; set; }
        public int? RegionId { get; set; }
        public string? RecipientCode { get; set; }
        public int? ProtocolId { get; set; }
        public long? CountAbonent { get; set; }
        public long? Juridical { get; set; }
        public long? Individual { get; set; }
    }
}
