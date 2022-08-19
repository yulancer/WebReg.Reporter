using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов видимости
    /// </summary>
    public partial class RoVisibilityType
    {
        public RoVisibilityType()
        {
            RoNews = new HashSet<RoNews>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int VisibilityTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string VisibilityTypeName { get; set; } = null!;

        public virtual ICollection<RoNews> RoNews { get; set; }
    }
}
