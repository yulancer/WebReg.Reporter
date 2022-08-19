using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек
    /// </summary>
    public partial class RoConfig
    {
        public string Key { get; set; } = null!;
        public string? Value { get; set; }
    }
}
