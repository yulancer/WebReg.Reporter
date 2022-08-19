using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица СОУН
    /// </summary>
    public partial class RoSoun
    {
        public RoSoun()
        {
            InverseParentTaxNavigation = new HashSet<RoSoun>();
        }

        /// <summary>
        /// Код инспекции
        /// </summary>
        public string TaxCode { get; set; } = null!;
        /// <summary>
        /// Код предыдущей инспекции
        /// </summary>
        public string? ParentTax { get; set; }
        /// <summary>
        /// Наименование инспекции
        /// </summary>
        public string? TaxName { get; set; }

        public virtual RoSoun? ParentTaxNavigation { get; set; }
        public virtual ICollection<RoSoun> InverseParentTaxNavigation { get; set; }
    }
}
