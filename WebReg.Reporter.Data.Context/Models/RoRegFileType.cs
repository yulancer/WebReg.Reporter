using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов рег-файлов
    /// </summary>
    public partial class RoRegFileType
    {
        public RoRegFileType()
        {
            RoProductPeople = new HashSet<RoProductPerson>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int RegFileTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RegFileTypeName { get; set; } = null!;

        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
