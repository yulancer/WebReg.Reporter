using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов проверок
    /// </summary>
    public partial class RoCheckingType
    {
        public RoCheckingType()
        {
            RoCheckingSchemes = new HashSet<RoCheckingScheme>();
            RoProductCheckings = new HashSet<RoProductChecking>();
            RoRegRequestCheckings = new HashSet<RoRegRequestChecking>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CheckingTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CheckingTypeName { get; set; } = null!;

        public virtual ICollection<RoCheckingScheme> RoCheckingSchemes { get; set; }
        public virtual ICollection<RoProductChecking> RoProductCheckings { get; set; }
        public virtual ICollection<RoRegRequestChecking> RoRegRequestCheckings { get; set; }
    }
}
