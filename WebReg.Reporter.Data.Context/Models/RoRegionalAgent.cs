using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Региональные дистрибьютеры 1С по схеме учета от 1С
    /// </summary>
    public partial class RoRegionalAgent
    {
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Дистрибьютор
        /// </summary>
        public int AgentId { get; set; }

        public virtual RoRegion Region { get; set; } = null!;
    }
}
