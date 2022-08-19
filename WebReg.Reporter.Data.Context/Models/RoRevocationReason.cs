using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Причина отзыва
    /// </summary>
    public partial class RoRevocationReason
    {
        public RoRevocationReason()
        {
            RoCertificateRevocations = new HashSet<RoCertificateRevocation>();
            RoCertificateSteps = new HashSet<RoCertificateStep>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ReasonId { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string ReasonDescription { get; set; } = null!;

        public virtual ICollection<RoCertificateRevocation> RoCertificateRevocations { get; set; }
        public virtual ICollection<RoCertificateStep> RoCertificateSteps { get; set; }
    }
}
