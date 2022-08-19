using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// таблица с информацией о наличии у партнера соглашения
    /// </summary>
    public partial class RoAgentAgreement
    {
        /// <summary>
        /// Id соглашения
        /// </summary>
        public int AgreementId { get; set; }
        /// <summary>
        /// Наличие соглашения
        /// </summary>
        public bool? AgreementIs { get; set; }
        public string? AgreementDescription { get; set; }
        public int AgentId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
    }
}
