using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCaService
    {
        /// <summary>
        /// Тип услуги
        /// </summary>
        public int CaServiceTypeId { get; set; }
        /// <summary>
        /// Схема
        /// </summary>
        public int SchemeId { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        public virtual RoCaServiceType CaServiceType { get; set; } = null!;
        public virtual RoAgentScheme Scheme { get; set; } = null!;
    }
}
