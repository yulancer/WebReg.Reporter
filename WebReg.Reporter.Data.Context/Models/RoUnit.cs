using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ед. измерения
    /// </summary>
    public partial class RoUnit
    {
        public RoUnit()
        {
            RoCaTemplateAttributes = new HashSet<RoCaTemplateAttribute>();
            RoDssUserGroups = new HashSet<RoDssUserGroup>();
            RoOfdDevices = new HashSet<RoOfdDevice>();
            RoOfdPinTemplates = new HashSet<RoOfdPinTemplate>();
            RoOfdPins = new HashSet<RoOfdPin>();
            RoTariffAttributes = new HashSet<RoTariffAttribute>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string UnitName { get; set; } = null!;
        /// <summary>
        /// Тип
        /// </summary>
        public int UnitTypeId { get; set; }

        public virtual RoUnitType UnitType { get; set; } = null!;
        public virtual ICollection<RoCaTemplateAttribute> RoCaTemplateAttributes { get; set; }
        public virtual ICollection<RoDssUserGroup> RoDssUserGroups { get; set; }
        public virtual ICollection<RoOfdDevice> RoOfdDevices { get; set; }
        public virtual ICollection<RoOfdPinTemplate> RoOfdPinTemplates { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
        public virtual ICollection<RoTariffAttribute> RoTariffAttributes { get; set; }
    }
}
