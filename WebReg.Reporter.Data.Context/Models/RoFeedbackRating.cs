using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица возможных оценок при обратной связи
    /// </summary>
    public partial class RoFeedbackRating
    {
        public RoFeedbackRating()
        {
            RoRegRequestFeedbacks = new HashSet<RoRegRequestFeedback>();
            RoWorkflowFeedbacks = new HashSet<RoWorkflowFeedback>();
        }

        /// <summary>
        /// Оценка
        /// </summary>
        public int RatingId { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Label { get; set; } = null!;

        public virtual ICollection<RoRegRequestFeedback> RoRegRequestFeedbacks { get; set; }
        public virtual ICollection<RoWorkflowFeedback> RoWorkflowFeedbacks { get; set; }
    }
}
