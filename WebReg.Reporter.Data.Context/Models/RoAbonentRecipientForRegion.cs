using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает всех абонов согласно направлений и связывает их по регионам
    /// </summary>
    public partial class RoAbonentRecipientForRegion
    {
        public int? AbonentId { get; set; }
        public int? RegionId { get; set; }
        public string? RecipientCode { get; set; }
        public int? IsIndividual { get; set; }
        public int? ProtocolId { get; set; }
        public DateTime? ConnectionDate { get; set; }
        public int? ProductId { get; set; }
    }
}
