using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает выборку все ФСРаР по продуктам
    /// </summary>
    public partial class FcrarCertView
    {
        public int? ProductId { get; set; }
        public int? AgentId { get; set; }
    }
}
