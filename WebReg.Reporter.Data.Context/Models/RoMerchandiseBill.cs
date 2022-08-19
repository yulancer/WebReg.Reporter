using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Связь счетов и номенклатур
    /// </summary>
    public partial class RoMerchandiseBill
    {
        public RoMerchandiseBill()
        {
            RoSkziLicenses = new HashSet<RoSkziLicense>();
        }

        public int MerchandiseBillId { get; set; }
        public int? BillId { get; set; }
        public int? Count { get; set; }
        public int? MerchandiseId { get; set; }
        public decimal TotalSum { get; set; }
        /// <summary>
        /// Вознаграждение
        /// </summary>
        public decimal? SumReward { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// Вознаграждение ЦП
        /// </summary>
        public decimal? ScSumReward { get; set; }

        public virtual RoSendedBill? Bill { get; set; }
        public virtual RoMerchandise? Merchandise { get; set; }
        public virtual ICollection<RoSkziLicense> RoSkziLicenses { get; set; }
    }
}
