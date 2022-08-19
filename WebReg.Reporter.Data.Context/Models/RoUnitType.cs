using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов ед. измерений
    /// </summary>
    public partial class RoUnitType
    {
        public RoUnitType()
        {
            RoUnits = new HashSet<RoUnit>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int UnitTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string UnitTypeName { get; set; } = null!;

        public virtual ICollection<RoUnit> RoUnits { get; set; }
    }
}
