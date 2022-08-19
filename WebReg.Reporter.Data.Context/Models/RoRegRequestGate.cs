using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица гейтов заявлений
    /// </summary>
    public partial class RoRegRequestGate
    {
        public int RegRequestGateId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }

        public virtual RoGate Gate { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
    }
}
