using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица масок темы для ПФР
    /// </summary>
    public partial class RoPfrSchemeSubjectMask
    {
        public RoPfrSchemeSubjectMask()
        {
            RoPfrLayoutSchemes = new HashSet<RoPfrLayoutScheme>();
        }

        /// <summary>
        /// ИД маски
        /// </summary>
        public int SubjectMaskId { get; set; }
        /// <summary>
        /// Маска
        /// </summary>
        public string SubjectMask { get; set; } = null!;

        public virtual ICollection<RoPfrLayoutScheme> RoPfrLayoutSchemes { get; set; }
    }
}
