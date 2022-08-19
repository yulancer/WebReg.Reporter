using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов документов удостоверяющих личность
    /// </summary>
    public partial class RoPassportType
    {
        public RoPassportType()
        {
            RoDocs = new HashSet<RoDoc>();
            RoPeople = new HashSet<RoPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PassportTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PassportTypeName { get; set; } = null!;
        /// <summary>
        /// Код
        /// </summary>
        public string? PassportTypeCode { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string? PassportTypeNote { get; set; }

        public virtual ICollection<RoDoc> RoDocs { get; set; }
        public virtual ICollection<RoPerson> RoPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
