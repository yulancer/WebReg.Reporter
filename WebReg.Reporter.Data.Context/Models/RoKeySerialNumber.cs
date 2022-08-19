using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица связи ключ - серийный номер носителя
    /// </summary>
    public partial class RoKeySerialNumber
    {
        /// <summary>
        /// Ключ
        /// </summary>
        public int KeyId { get; set; }
        /// <summary>
        /// Серийный номер носителя
        /// </summary>
        public string SerialNumber { get; set; } = null!;

        public virtual RoKey Key { get; set; } = null!;
    }
}
