using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Тип применения точки
    /// </summary>
    public partial class RoPointUseType
    {
        public RoPointUseType()
        {
            RoPointUses = new HashSet<RoPointUse>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int UseTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string UseTypeName { get; set; } = null!;

        public virtual ICollection<RoPointUse> RoPointUses { get; set; }
    }
}
