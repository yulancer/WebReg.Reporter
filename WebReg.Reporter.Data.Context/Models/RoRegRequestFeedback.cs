using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица обратной связи по заявлениям
    /// </summary>
    public partial class RoRegRequestFeedback
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FeedbackId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Оценка
        /// </summary>
        public int? RatingId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }

        public virtual RoFeedbackRating? Rating { get; set; }
        public virtual RoRegRequest RegRequest { get; set; } = null!;
    }
}
