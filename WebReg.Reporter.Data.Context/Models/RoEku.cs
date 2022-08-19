using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица расширений сертификата
    /// </summary>
    public partial class RoEku
    {
        public RoEku()
        {
            RoAttributeEkus = new HashSet<RoAttributeEku>();
            RoCertTemplateEkus = new HashSet<RoCertTemplateEku>();
            ProductPeople = new HashSet<RoProductPerson>();
            RegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int EkuId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string EkuName { get; set; } = null!;
        /// <summary>
        /// Объектный идентификатор
        /// </summary>
        public string EkuOid { get; set; } = null!;
        /// <summary>
        /// Обязательный
        /// </summary>
        public bool Required { get; set; }

        public virtual ICollection<RoAttributeEku> RoAttributeEkus { get; set; }
        public virtual ICollection<RoCertTemplateEku> RoCertTemplateEkus { get; set; }

        public virtual ICollection<RoProductPerson> ProductPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RegRequestMembers { get; set; }
    }
}
