using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoTagGroup
    {
        public RoTagGroup()
        {
            RoTags = new HashSet<RoTag>();
        }

        /// <summary>
        /// Ид. группа
        /// </summary>
        public int TagGroupId { get; set; }
        /// <summary>
        /// Наименование группы
        /// </summary>
        public string TagGroupName { get; set; } = null!;

        public virtual ICollection<RoTag> RoTags { get; set; }
    }
}
