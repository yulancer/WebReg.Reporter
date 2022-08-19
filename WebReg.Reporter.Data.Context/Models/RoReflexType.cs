using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов отражений
    /// </summary>
    public partial class RoReflexType
    {
        public RoReflexType()
        {
            RoReflexMessengers = new HashSet<RoReflexMessenger>();
            RoReflexProductTypes = new HashSet<RoReflexProductType>();
            RoReflexProducts = new HashSet<RoReflexProduct>();
            RoReflexRules = new HashSet<RoReflexRule>();
            RoReflexTypeSystems = new HashSet<RoReflexTypeSystem>();
            RoReflexUseTypes = new HashSet<RoReflexUseType>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ReflexTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ReflexTypeName { get; set; } = null!;

        public virtual ICollection<RoReflexMessenger> RoReflexMessengers { get; set; }
        public virtual ICollection<RoReflexProductType> RoReflexProductTypes { get; set; }
        public virtual ICollection<RoReflexProduct> RoReflexProducts { get; set; }
        public virtual ICollection<RoReflexRule> RoReflexRules { get; set; }
        public virtual ICollection<RoReflexTypeSystem> RoReflexTypeSystems { get; set; }
        public virtual ICollection<RoReflexUseType> RoReflexUseTypes { get; set; }
    }
}
