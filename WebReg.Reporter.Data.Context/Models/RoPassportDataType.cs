using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов данных паспорта
    /// </summary>
    public partial class RoPassportDataType
    {
        public RoPassportDataType()
        {
            RoProductPassportCheckings = new HashSet<RoProductPassportChecking>();
            RoRegRequestPassportCheckings = new HashSet<RoRegRequestPassportChecking>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int PassportDataTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PassportDataTypeName { get; set; } = null!;

        public virtual ICollection<RoProductPassportChecking> RoProductPassportCheckings { get; set; }
        public virtual ICollection<RoRegRequestPassportChecking> RoRegRequestPassportCheckings { get; set; }
    }
}
