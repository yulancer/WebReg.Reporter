using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoRegRequestEgrulRequest
    {
        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Идентификатор запроса на выписку ЕГРЮЛ
        /// </summary>
        public string EgrulRequestId { get; set; } = null!;
        /// <summary>
        /// Дата получения документа
        /// </summary>
        public DateTime? OffTime { get; set; }
    }
}
