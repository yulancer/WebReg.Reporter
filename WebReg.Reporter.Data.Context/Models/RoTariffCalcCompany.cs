using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица список компаний для тарифного калькулятора.
    /// </summary>
    public partial class RoTariffCalcCompany
    {
        public RoTariffCalcCompany()
        {
            RoTariffCalcTariffs = new HashSet<RoTariffCalcTariff>();
        }

        /// <summary>
        /// Id компании.
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// Имя компании.
        /// </summary>
        public string Name { get; set; } = null!;

        public virtual ICollection<RoTariffCalcTariff> RoTariffCalcTariffs { get; set; }
    }
}
