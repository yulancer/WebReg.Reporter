using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица роутинга ПФР
    /// </summary>
    public partial class RoRoutePfr
    {
        public RoRoutePfr()
        {
            InverseRoutePfrNavigation = new HashSet<RoRoutePfr>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public string PfrCode { get; set; } = null!;
        /// <summary>
        /// Код роутинга
        /// </summary>
        public string? RoutePfr { get; set; }
        /// <summary>
        /// Код макета
        /// </summary>
        public string? LayoutPfr { get; set; }
        /// <summary>
        /// Маска файла
        /// </summary>
        public int FileMaskId { get; set; }

        public virtual RoFileMask FileMask { get; set; } = null!;
        public virtual RoRoutePfr? RoutePfrNavigation { get; set; }
        public virtual ICollection<RoRoutePfr> InverseRoutePfrNavigation { get; set; }
    }
}
