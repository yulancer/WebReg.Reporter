using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица шаблонов для УЦ
    /// </summary>
    public partial class RoCaTemplate
    {
        public RoCaTemplate()
        {
            RoCaTemplateAttributes = new HashSet<RoCaTemplateAttribute>();
            RoKeys = new HashSet<RoKey>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
            RoTariffAttributeCas = new HashSet<RoTariffAttributeCa>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TemplateId { get; set; }
        /// <summary>
        /// Удостоверяющий центр
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Идентификатор шаблона
        /// </summary>
        public string TemplateOid { get; set; } = null!;
        /// <summary>
        /// Идентификатор шаблона
        /// </summary>
        public int TemplateTypeId { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoCaTemplateType TemplateType { get; set; } = null!;
        public virtual ICollection<RoCaTemplateAttribute> RoCaTemplateAttributes { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
        public virtual ICollection<RoTariffAttributeCa> RoTariffAttributeCas { get; set; }
    }
}
