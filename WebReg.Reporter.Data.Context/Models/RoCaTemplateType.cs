using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Шаблоны Крипто про
    /// </summary>
    public partial class RoCaTemplateType
    {
        public RoCaTemplateType()
        {
            RoCaTemplates = new HashSet<RoCaTemplate>();
        }

        /// <summary>
        /// Идентификатор шаблона
        /// </summary>
        public int TemplateTypeId { get; set; }
        /// <summary>
        /// Наименование шаблона
        /// </summary>
        public string TemplateName { get; set; } = null!;

        public virtual ICollection<RoCaTemplate> RoCaTemplates { get; set; }
    }
}
