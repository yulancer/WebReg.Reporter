using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица масок файлов
    /// </summary>
    public partial class RoFileMask
    {
        public RoFileMask()
        {
            RoRoutePfrs = new HashSet<RoRoutePfr>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int FileMaskId { get; set; }
        /// <summary>
        /// Шаблон
        /// </summary>
        public string MaskTemplate { get; set; } = null!;

        public virtual ICollection<RoRoutePfr> RoRoutePfrs { get; set; }
    }
}
