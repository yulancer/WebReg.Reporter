using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdPrefix
    {
        public RoOfdPrefix()
        {
            RoOfdPins = new HashSet<RoOfdPin>();
        }

        /// <summary>
        /// Ид.
        /// </summary>
        public int PrefixId { get; set; }
        /// <summary>
        /// Префикс
        /// </summary>
        public string Prefix { get; set; } = null!;
        /// <summary>
        /// Ид. агента
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Длина генерируемого кода
        /// </summary>
        public int PinLength { get; set; }
        /// <summary>
        /// Время отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
    }
}
