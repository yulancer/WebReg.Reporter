using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Список номенклатур у партнера
    /// </summary>
    public partial class RoAgentMerchandise
    {
        /// <summary>
        /// Ид партнера которому выставляется счет
        /// </summary>
        public int BillToAgentId { get; set; }
        /// <summary>
        /// Ид номенклатуры
        /// </summary>
        public int MerchandiseId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        public int AgentMerchandiseId { get; set; }
        /// <summary>
        /// Агент от которого выставляется счет
        /// </summary>
        public int? BillFromAgentId { get; set; }

        public virtual RoAgent? BillFromAgent { get; set; }
        public virtual RoAgent BillToAgent { get; set; } = null!;
        public virtual RoMerchandise Merchandise { get; set; } = null!;
        public virtual RoProductType? ProductType { get; set; }
    }
}
