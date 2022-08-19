using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление со статистикой подключений абонентов по получателям для ФНС
    /// </summary>
    public partial class AbonentRecipientStatisticForFn
    {
        public int? RegionId { get; set; }
        public string? RecipientCode { get; set; }
        public decimal? TotalAbonent { get; set; }
        public decimal? TotalJuridical { get; set; }
        public decimal? TotalIndividual { get; set; }
        public decimal? MonthAbonent { get; set; }
        public decimal? MonthJuridical { get; set; }
        public decimal? MonthIndividual { get; set; }
    }
}
