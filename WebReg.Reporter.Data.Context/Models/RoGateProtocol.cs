using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица протоколов гейтов
    /// </summary>
    public partial class RoGateProtocol
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public int GateProtocolId { get; set; }
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }
        /// <summary>
        /// Протокол
        /// </summary>
        public int ProtocolId { get; set; }

        public virtual RoGate Gate { get; set; } = null!;
        public virtual RoProtocol Protocol { get; set; } = null!;
    }
}
