using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица дистрибьюторов ИТС
    /// </summary>
    public partial class RoItsDistributor
    {
        /// <summary>
        /// Наименование дистрибьютора
        /// </summary>
        public string ItsDistributorName { get; set; } = null!;
        /// <summary>
        /// ЦП
        /// </summary>
        public int? AgentId { get; set; }

        public virtual RoAgent? Agent { get; set; }
    }
}
