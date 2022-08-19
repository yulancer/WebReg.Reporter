using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает выборку все налоговые предст. по продуктам
    /// </summary>
    public partial class TaxRepre
    {
        public int? ProductId { get; set; }
        public int? AbonentId { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? AgentId { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
