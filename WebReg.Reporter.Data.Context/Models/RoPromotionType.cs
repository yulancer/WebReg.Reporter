using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с типами рекламных акций
    /// </summary>
    public partial class RoPromotionType
    {
        public RoPromotionType()
        {
            RoUserPromotionConfirmeds = new HashSet<RoUserPromotionConfirmed>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PromotionTypeId { get; set; }
        /// <summary>
        /// Имя акции
        /// </summary>
        public string PromotionTypeName { get; set; } = null!;

        public virtual ICollection<RoUserPromotionConfirmed> RoUserPromotionConfirmeds { get; set; }
    }
}
