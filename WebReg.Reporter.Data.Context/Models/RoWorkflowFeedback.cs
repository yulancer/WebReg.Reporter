using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица обратной связи по документооборотам
    /// </summary>
    public partial class RoWorkflowFeedback
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FeedbackId { get; set; }
        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Оценка
        /// </summary>
        public int? RatingId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }

        public virtual RoFeedbackRating? Rating { get; set; }
        public virtual RoWorkflow Workflow { get; set; } = null!;
    }
}
