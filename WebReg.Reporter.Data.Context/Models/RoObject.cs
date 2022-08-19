using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица объектов
    /// </summary>
    public partial class RoObject
    {
        public RoObject()
        {
            RoTransitions = new HashSet<RoTransition>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ObjectName { get; set; } = null!;
        /// <summary>
        /// Тип
        /// </summary>
        public int ObjectTypeId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string ObjectValue { get; set; } = null!;
        /// <summary>
        /// Тип значения
        /// </summary>
        public int ValueTypeId { get; set; }

        public virtual RoObjectType ObjectType { get; set; } = null!;
        public virtual RoValueType ValueType { get; set; } = null!;
        public virtual ICollection<RoTransition> RoTransitions { get; set; }
    }
}
