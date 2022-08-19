using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица групп тарифов
    /// </summary>
    public partial class RoTariffGroup
    {
        public RoTariffGroup()
        {
            RoTariffs = new HashSet<RoTariff>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TariffGroupId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TariffGroupName { get; set; } = null!;

        public virtual ICollection<RoTariff> RoTariffs { get; set; }
    }
}
