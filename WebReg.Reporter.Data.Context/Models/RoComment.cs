using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoComment
    {
        public RoComment()
        {
            RoOfdDiscounts = new HashSet<RoOfdDiscount>();
            RoOfdPins = new HashSet<RoOfdPin>();
        }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        public int CommentId { get; set; }
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string? CommentText { get; set; }

        public virtual ICollection<RoOfdDiscount> RoOfdDiscounts { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
    }
}
