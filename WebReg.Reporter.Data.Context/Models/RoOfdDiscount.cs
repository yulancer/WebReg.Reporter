using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdDiscount
    {
        public RoOfdDiscount()
        {
            RoOfdPins = new HashSet<RoOfdPin>();
        }

        /// <summary>
        /// Ид.
        /// </summary>
        public int OfdDiscountId { get; set; }
        /// <summary>
        /// Ид. скидки
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// Лимит использования
        /// </summary>
        public int? UseLimit { get; set; }
        /// <summary>
        /// Ид. коментария
        /// </summary>
        public int? CommentId { get; set; }

        public virtual RoComment? Comment { get; set; }
        public virtual RoDiscount Discount { get; set; } = null!;
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
    }
}
