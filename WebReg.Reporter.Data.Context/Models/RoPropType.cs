using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов реквизитов
    /// </summary>
    public partial class RoPropType
    {
        public RoPropType()
        {
            RoPropDicts = new HashSet<RoPropDict>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int PropTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PropTypeName { get; set; } = null!;

        public virtual ICollection<RoPropDict> RoPropDicts { get; set; }
    }
}
