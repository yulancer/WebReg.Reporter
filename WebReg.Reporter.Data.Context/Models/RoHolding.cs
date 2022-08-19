using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoHolding
    {
        /// <summary>
        /// Головная организация
        /// </summary>
        public int ParentAbonentId { get; set; }
        /// <summary>
        /// Организация
        /// </summary>
        public int AbonentId { get; set; }
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
        public int HoldingId { get; set; }

        public virtual RoHoldingAbonent Abonent { get; set; } = null!;
        public virtual RoHoldingAbonent ParentAbonent { get; set; } = null!;
    }
}
