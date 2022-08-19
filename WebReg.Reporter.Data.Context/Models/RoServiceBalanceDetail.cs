using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Дополнительные услуги в сверке между партнером и Центром продаж
    /// </summary>
    public partial class RoServiceBalanceDetail
    {
        /// <summary>
        /// Идентификатор дополнительной услуги в сверке
        /// </summary>
        public int ServiceBalanceDetailId { get; set; }
        /// <summary>
        /// Позиция в сверке
        /// </summary>
        public int BalanceDetailId { get; set; }
        /// <summary>
        /// Тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }
        /// <summary>
        /// Номер услуги
        /// </summary>
        public string? ServiceNumber { get; set; }

        public virtual RoAgentBalanceDetail BalanceDetail { get; set; } = null!;
        public virtual RoServiceType ServiceType { get; set; } = null!;
    }
}
