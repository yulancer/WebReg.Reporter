using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов закупок
    /// </summary>
    public partial class RoPurchaseType
    {
        public RoPurchaseType()
        {
            RoPotentialAbonentRts = new HashSet<RoPotentialAbonentRt>();
        }

        /// <summary>
        /// Идентификатор типа закупки
        /// </summary>
        public int PurchaseTypeId { get; set; }
        /// <summary>
        /// Наименование типа закупки
        /// </summary>
        public string PurchaseTypeName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentRt> RoPotentialAbonentRts { get; set; }
    }
}
