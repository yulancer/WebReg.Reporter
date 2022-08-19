using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoMerchandiseType
    {
        public RoMerchandiseType()
        {
            RoMerchandises = new HashSet<RoMerchandise>();
        }

        /// <summary>
        /// Ид
        /// </summary>
        public int MerchandiseTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string MerchandiseTypeName { get; set; } = null!;

        public virtual ICollection<RoMerchandise> RoMerchandises { get; set; }
    }
}
