using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdPinTemplate
    {
        public RoOfdPinTemplate()
        {
            RoOfdPinTemplateLimits = new HashSet<RoOfdPinTemplateLimit>();
            RoOfdPins = new HashSet<RoOfdPin>();
            OfdPins = new HashSet<RoOfdPin>();
        }

        /// <summary>
        /// Ид
        /// </summary>
        public Guid OfdPinTemplateId { get; set; }
        /// <summary>
        /// Срок действия
        /// </summary>
        public int? Validity { get; set; }
        /// <summary>
        /// Единица измерения срока действия
        /// </summary>
        public int? ValidityUnitId { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Цена для партнёра
        /// </summary>
        public decimal AgentPrice { get; set; }
        /// <summary>
        /// Цена для ЦП
        /// </summary>
        public decimal ScPrice { get; set; }
        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Номенклатура
        /// </summary>
        public string? Article { get; set; }
        /// <summary>
        /// Ид. ЦП
        /// </summary>
        public int? SaleCenterId { get; set; }
        /// <summary>
        /// Читаемый код
        /// </summary>
        public string? SecretId { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string? TemplateName { get; set; }
        /// <summary>
        /// Цена для 1С
        /// </summary>
        public decimal? Cost1c { get; set; }
        /// <summary>
        /// Тип пин кода
        /// </summary>
        public int OfdPinTypeId { get; set; }

        public virtual RoOfdPinType OfdPinType { get; set; } = null!;
        public virtual RoAgent? SaleCenter { get; set; }
        public virtual RoUnit? ValidityUnit { get; set; }
        public virtual ICollection<RoOfdPinTemplateLimit> RoOfdPinTemplateLimits { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }

        public virtual ICollection<RoOfdPin> OfdPins { get; set; }
    }
}
