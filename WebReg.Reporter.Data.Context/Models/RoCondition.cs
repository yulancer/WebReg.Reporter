using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица условий
    /// </summary>
    public partial class RoCondition
    {
        public RoCondition()
        {
            RoTransitions = new HashSet<RoTransition>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ConditionId { get; set; }
        /// <summary>
        /// ГУИД условия
        /// </summary>
        public Guid ConditionGuid { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; } = null!;

        public virtual ICollection<RoTransition> RoTransitions { get; set; }
    }
}
