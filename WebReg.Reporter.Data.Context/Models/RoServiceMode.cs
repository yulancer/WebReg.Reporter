using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с режимами услуг
    /// </summary>
    public partial class RoServiceMode
    {
        public RoServiceMode()
        {
            RoServiceTypes = new HashSet<RoServiceType>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ServiceModeId { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Описание режима
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<RoServiceType> RoServiceTypes { get; set; }
    }
}
