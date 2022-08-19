using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица версий БД
    /// </summary>
    public partial class RoVersion
    {
        /// <summary>
        /// Номер
        /// </summary>
        public string VersionNumber { get; set; } = null!;
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
