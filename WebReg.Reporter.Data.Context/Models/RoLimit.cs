using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ограничений
    /// </summary>
    public partial class RoLimit
    {
        public RoLimit()
        {
            RoOfdPinTemplateLimits = new HashSet<RoOfdPinTemplateLimit>();
            RoTariffAttributeLimits = new HashSet<RoTariffAttributeLimit>();
            RoTariffAttributes = new HashSet<RoTariffAttribute>();
            RoTariffLimits = new HashSet<RoTariffLimit>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int LimitId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string LimitName { get; set; } = null!;
        /// <summary>
        /// Гуид
        /// </summary>
        public Guid LimitGuid { get; set; }

        public virtual ICollection<RoOfdPinTemplateLimit> RoOfdPinTemplateLimits { get; set; }
        public virtual ICollection<RoTariffAttributeLimit> RoTariffAttributeLimits { get; set; }
        public virtual ICollection<RoTariffAttribute> RoTariffAttributes { get; set; }
        public virtual ICollection<RoTariffLimit> RoTariffLimits { get; set; }
    }
}
