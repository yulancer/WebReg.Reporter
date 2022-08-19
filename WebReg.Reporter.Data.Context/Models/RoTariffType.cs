using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов тарифов
    /// </summary>
    public partial class RoTariffType
    {
        public RoTariffType()
        {
            RoTariffs = new HashSet<RoTariff>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int TariffTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffTypeName { get; set; } = null!;

        public virtual ICollection<RoTariff> RoTariffs { get; set; }
    }
}
