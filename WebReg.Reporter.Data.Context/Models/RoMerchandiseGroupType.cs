using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMerchandiseGroupType
    {
        public RoMerchandiseGroupType()
        {
            RoMerchandiseGroups = new HashSet<RoMerchandiseGroup>();
        }

        /// <summary>
        /// Ид
        /// </summary>
        public int MerchandiseGroupTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string MerchandiseGroupTypeName { get; set; } = null!;

        public virtual ICollection<RoMerchandiseGroup> RoMerchandiseGroups { get; set; }
    }
}
