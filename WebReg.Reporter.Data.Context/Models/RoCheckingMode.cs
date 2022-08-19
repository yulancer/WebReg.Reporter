using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с режимами проверки
    /// </summary>
    public partial class RoCheckingMode
    {
        public RoCheckingMode()
        {
            RoCheckingSchemes = new HashSet<RoCheckingScheme>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CheckingModeId { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Описание режима
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<RoCheckingScheme> RoCheckingSchemes { get; set; }
    }
}
