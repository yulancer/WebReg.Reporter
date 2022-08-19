using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов значений
    /// </summary>
    public partial class RoValueType
    {
        public RoValueType()
        {
            RoObjects = new HashSet<RoObject>();
            RoSettings = new HashSet<RoSetting>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ValueTypeId { get; set; }
        /// <summary>
        /// Кодовое имя
        /// </summary>
        public string CodeName { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string ValueTypeName { get; set; } = null!;

        public virtual ICollection<RoObject> RoObjects { get; set; }
        public virtual ICollection<RoSetting> RoSettings { get; set; }
    }
}
