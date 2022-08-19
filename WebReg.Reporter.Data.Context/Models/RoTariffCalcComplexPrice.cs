using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Цены тарифов и доп. возможностей в сложном формате.
    /// </summary>
    public partial class RoTariffCalcComplexPrice
    {
        /// <summary>
        /// Id цены которой принаджлежат условия
        /// </summary>
        public int PriceId { get; set; }
        /// <summary>
        /// Описание части сложной цены
        /// </summary>
        public string Desk { get; set; } = null!;
        /// <summary>
        /// Цена части сложной цены
        /// </summary>
        public decimal Price { get; set; }

        public virtual RoTariffCalcPrice PriceNavigation { get; set; } = null!;
    }
}
