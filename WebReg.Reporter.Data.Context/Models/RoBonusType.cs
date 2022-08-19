using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов премий
    /// </summary>
    public partial class RoBonusType
    {
        public RoBonusType()
        {
            RoBonus = new HashSet<RoBonu>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int BonusTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string BonusTypeName { get; set; } = null!;

        public virtual ICollection<RoBonu> RoBonus { get; set; }
    }
}
