using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица со списком потдтверждённых пользователями акций
    /// </summary>
    public partial class RoUserPromotionConfirmed
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Идентификатор рекламной акции
        /// </summary>
        public int PromotionTypeId { get; set; }
        /// <summary>
        /// Дата подтверждения
        /// </summary>
        public DateTime ConfirmDate { get; set; }

        public virtual RoPromotionType PromotionType { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
