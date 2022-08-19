using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица масок файлов для ПФР
    /// </summary>
    public partial class RoPfrSchemeFileMask
    {
        public RoPfrSchemeFileMask()
        {
            RoPfrLayoutSchemes = new HashSet<RoPfrLayoutScheme>();
        }

        /// <summary>
        /// ИД маски
        /// </summary>
        public int FileMaskId { get; set; }
        /// <summary>
        /// Маска
        /// </summary>
        public string FileMask { get; set; } = null!;

        public virtual ICollection<RoPfrLayoutScheme> RoPfrLayoutSchemes { get; set; }
    }
}
