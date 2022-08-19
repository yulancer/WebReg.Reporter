using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdPinType
    {
        public RoOfdPinType()
        {
            RoOfdPinTemplates = new HashSet<RoOfdPinTemplate>();
            RoOfdPins = new HashSet<RoOfdPin>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OfdPinTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RoOfdPinTypeName { get; set; } = null!;

        public virtual ICollection<RoOfdPinTemplate> RoOfdPinTemplates { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
    }
}
