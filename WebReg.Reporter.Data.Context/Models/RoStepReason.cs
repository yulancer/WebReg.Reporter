using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Причины статусов
    /// </summary>
    public partial class RoStepReason
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int StepReasonId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string StepReasonName { get; set; } = null!;
    }
}
