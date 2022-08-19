using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с отзывами к новостям
    /// </summary>
    public partial class RoNewsReview
    {
        /// <summary>
        /// идентификатор отзыва новости
        /// </summary>
        public int NewsReviewId { get; set; }
        /// <summary>
        /// новость
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// текст отзыва
        /// </summary>
        public string? ReviewText { get; set; }

        public virtual RoNews News { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
