using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица для типов тарифов
    /// </summary>
    public partial class RoPotentialAbonentTariffType
    {
        public RoPotentialAbonentTariffType()
        {
            RoPotentialAbonentTariffs = new HashSet<RoPotentialAbonentTariff>();
        }

        /// <summary>
        /// ID типа тарифа
        /// </summary>
        public int TariffTypeId { get; set; }
        /// <summary>
        /// Наименование типа тарифа
        /// </summary>
        public string TariffTypeName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentTariff> RoPotentialAbonentTariffs { get; set; }
    }
}
