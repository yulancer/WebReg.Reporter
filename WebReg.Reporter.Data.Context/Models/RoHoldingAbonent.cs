using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoHoldingAbonent
    {
        public RoHoldingAbonent()
        {
            RoHoldingAbonents = new HashSet<RoHolding>();
            RoHoldingParentAbonents = new HashSet<RoHolding>();
        }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Время отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Ид
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Ид партнёра 1С
        /// </summary>
        public string AgentId { get; set; } = null!;
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;

        public virtual ICollection<RoHolding> RoHoldingAbonents { get; set; }
        public virtual ICollection<RoHolding> RoHoldingParentAbonents { get; set; }
    }
}
