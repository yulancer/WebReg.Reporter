using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Представление с датами регистрации продуктов
    /// </summary>
    public partial class ProductRegDate
    {
        public int? ProductId { get; set; }
        public int? AgentId { get; set; }
        public DateTime? RegDate { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
