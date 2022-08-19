using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица модулей
    /// </summary>
    public partial class RoModule
    {
        public RoModule()
        {
            RoModuleTariffs = new HashSet<RoModuleTariff>();
            RoRoleModules = new HashSet<RoRoleModule>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string MuduleName { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int TypeId { get; set; }

        public virtual RoProductType? ProductType { get; set; }
        public virtual RoModuleType Type { get; set; } = null!;
        public virtual ICollection<RoModuleTariff> RoModuleTariffs { get; set; }
        public virtual ICollection<RoRoleModule> RoRoleModules { get; set; }
    }
}
