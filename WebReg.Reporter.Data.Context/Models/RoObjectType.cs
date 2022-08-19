using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов объектов
    /// </summary>
    public partial class RoObjectType
    {
        public RoObjectType()
        {
            RoObjects = new HashSet<RoObject>();
            RoTransitions = new HashSet<RoTransition>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ObjectTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ObjectTypeName { get; set; } = null!;

        public virtual ICollection<RoObject> RoObjects { get; set; }
        public virtual ICollection<RoTransition> RoTransitions { get; set; }
    }
}
