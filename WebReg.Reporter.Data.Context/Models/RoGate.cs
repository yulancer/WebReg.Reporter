using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица шлюзов
    /// </summary>
    public partial class RoGate
    {
        public RoGate()
        {
            RoGateProductTypes = new HashSet<RoGateProductType>();
            RoGateProtocols = new HashSet<RoGateProtocol>();
            RoGateSettings = new HashSet<RoGateSetting>();
            RoGateUpdaters = new HashSet<RoGateUpdater>();
            RoProductNetNodes = new HashSet<RoProductNetNode>();
            RoRegRequestGates = new HashSet<RoRegRequestGate>();
            RoWorkflowServices = new HashSet<RoWorkflowService>();
            Tokens = new HashSet<RoToken>();
        }

        /// <summary>
        /// ГУИД
        /// </summary>
        public Guid GateId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string GateName { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertificateId { get; set; }
        public int? SystemId { get; set; }
        public bool IsVirtual { get; set; }

        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoUpdateSystem? System { get; set; }
        public virtual ICollection<RoGateProductType> RoGateProductTypes { get; set; }
        public virtual ICollection<RoGateProtocol> RoGateProtocols { get; set; }
        public virtual ICollection<RoGateSetting> RoGateSettings { get; set; }
        public virtual ICollection<RoGateUpdater> RoGateUpdaters { get; set; }
        public virtual ICollection<RoProductNetNode> RoProductNetNodes { get; set; }
        public virtual ICollection<RoRegRequestGate> RoRegRequestGates { get; set; }
        public virtual ICollection<RoWorkflowService> RoWorkflowServices { get; set; }

        public virtual ICollection<RoToken> Tokens { get; set; }
    }
}
