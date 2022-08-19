using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Действие на УЦ
    /// </summary>
    public partial class RoCaAction
    {
        public RoCaAction()
        {
            RoCertificateRevocations = new HashSet<RoCertificateRevocation>();
            RoCertificateSteps = new HashSet<RoCertificateStep>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ActionId { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string ActionDescription { get; set; } = null!;

        public virtual ICollection<RoCertificateRevocation> RoCertificateRevocations { get; set; }
        public virtual ICollection<RoCertificateStep> RoCertificateSteps { get; set; }
    }
}
