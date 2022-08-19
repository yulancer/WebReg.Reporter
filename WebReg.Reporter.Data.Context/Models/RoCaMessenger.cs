using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица связи УЦ и курьеров
    /// </summary>
    public partial class RoCaMessenger
    {
        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoMessenger Messenger { get; set; } = null!;
    }
}
