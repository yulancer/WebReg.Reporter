using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Тип модуля
    /// </summary>
    public partial class RoModuleType
    {
        public RoModuleType()
        {
            RoModules = new HashSet<RoModule>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ModuleTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ModuleTypeName { get; set; } = null!;

        public virtual ICollection<RoModule> RoModules { get; set; }
    }
}
