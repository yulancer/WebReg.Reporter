using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoNewsBrowsing
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// Время просмотра
        /// </summary>
        public DateTime BrowseTime { get; set; }
        /// <summary>
        /// Время установки флага like
        /// </summary>
        public DateTime? LikeTime { get; set; }

        public virtual RoNews News { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
