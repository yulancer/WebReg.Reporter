using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Выпуски КЦР
    /// </summary>
    public partial class RoKcrIssue
    {
        public int IssueId { get; set; }
        public Guid? IssueGuid { get; set; }
        public int RegRequestId { get; set; }
        public int AbonentTypeId { get; set; }
        /// <summary>
        /// максимальное количество КЭП
        /// </summary>
        public int MaxAmount { get; set; }
        /// <summary>
        /// выпущенное количество КЭП
        /// </summary>
        public int IssuedAmount { get; set; }
        /// <summary>
        /// дата истечения срока действия договора
        /// </summary>
        public DateOnly ExpiryDate { get; set; }
        public int SectionId { get; set; }
        public int TariffId { get; set; }
        /// <summary>
        /// id тарифа на выпуск КЭП
        /// </summary>
        public Guid PriceTariffGuid { get; set; }
        /// <summary>
        /// id расширения
        /// </summary>
        public Guid? ExtensionGuid { get; set; }
        /// <summary>
        /// выпуск открыт
        /// </summary>
        public bool IsActive { get; set; }
        public string? Article { get; set; }
        public int? TariffDiscountId { get; set; }

        public virtual RoAbonentType AbonentType { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoPriceTariff RoPriceTariff { get; set; } = null!;
        public virtual RoTariffDiscount? TariffDiscount { get; set; }
    }
}
