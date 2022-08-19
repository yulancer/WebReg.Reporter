using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoRegRequestConfirmedStep
    {
        /// <summary>
        /// Заявка
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Время подтверждения
        /// </summary>
        public DateTime ConfirmationTime { get; set; }

        public virtual RoRegRequest RegRequest { get; set; } = null!;
    }
}
