using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов договоров
    /// </summary>
    public partial class RoContractType
    {
        public RoContractType()
        {
            RoAgentContracts = new HashSet<RoAgentContract>();
            RoContracts = new HashSet<RoContract>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ContractTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ContractTypeName { get; set; } = null!;

        public virtual ICollection<RoAgentContract> RoAgentContracts { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
    }
}
