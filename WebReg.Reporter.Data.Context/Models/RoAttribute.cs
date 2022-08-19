using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица атрибутов (номенклатуры)
    /// </summary>
    public partial class RoAttribute
    {
        public RoAttribute()
        {
            RoAttributeDocumentTypes = new HashSet<RoAttributeDocumentType>();
            RoAttributeEkus = new HashSet<RoAttributeEku>();
            RoCaTemplateAttributes = new HashSet<RoCaTemplateAttribute>();
            RoRewardOptions = new HashSet<RoRewardOption>();
            RoTariffAttributes = new HashSet<RoTariffAttribute>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string AttributeName { get; set; } = null!;
        /// <summary>
        /// Тип
        /// </summary>
        public int AttributeTypeId { get; set; }
        /// <summary>
        /// Гуид
        /// </summary>
        public Guid AttributeGuid { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual RoAttributeType AttributeType { get; set; } = null!;
        public virtual ICollection<RoAttributeDocumentType> RoAttributeDocumentTypes { get; set; }
        public virtual ICollection<RoAttributeEku> RoAttributeEkus { get; set; }
        public virtual ICollection<RoCaTemplateAttribute> RoCaTemplateAttributes { get; set; }
        public virtual ICollection<RoRewardOption> RoRewardOptions { get; set; }
        public virtual ICollection<RoTariffAttribute> RoTariffAttributes { get; set; }
    }
}
