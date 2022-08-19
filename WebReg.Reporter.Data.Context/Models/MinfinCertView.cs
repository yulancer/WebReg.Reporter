using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает выборку все МинФин по продуктам
    /// </summary>
    public partial class MinfinCertView
    {
        public int? ProductId { get; set; }
        public int? AgentId { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
