using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица тарифов 1С-ЭТП
    /// </summary>
    public partial class RoPotentialAbonentTariff
    {
        public RoPotentialAbonentTariff()
        {
            RoPotentialAbonentTariffAbonents = new HashSet<RoPotentialAbonentTariffAbonent>();
        }

        /// <summary>
        /// ID тарифа
        /// </summary>
        public int TariffId { get; set; }
        /// <summary>
        /// Наименование тарифа
        /// </summary>
        public string TariffName { get; set; } = null!;
        /// <summary>
        /// Цена
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// ID типа тарифа
        /// </summary>
        public int TariffTypeId { get; set; }

        public virtual RoPotentialAbonentTariffType TariffType { get; set; } = null!;
        public virtual ICollection<RoPotentialAbonentTariffAbonent> RoPotentialAbonentTariffAbonents { get; set; }
    }
}
