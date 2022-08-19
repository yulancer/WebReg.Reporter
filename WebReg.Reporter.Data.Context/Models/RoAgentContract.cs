using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица договоров
    /// </summary>
    public partial class RoAgentContract
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AgentContractId { get; set; }
        /// <summary>
        /// Агент
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ContractName { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int ContractTypeId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoContractType ContractType { get; set; } = null!;
        public virtual RoOffice? Office { get; set; }
    }
}
