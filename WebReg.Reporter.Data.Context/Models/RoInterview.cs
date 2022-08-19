using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица опросов
    /// </summary>
    public partial class RoInterview
    {
        public RoInterview()
        {
            RoInterviewAnswers = new HashSet<RoInterviewAnswer>();
            RoInterviewSteps = new HashSet<RoInterviewStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int InterviewId { get; set; }
        /// <summary>
        /// Содержание
        /// </summary>
        public string Subject { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Множественный выбор
        /// </summary>
        public bool MultySelect { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoInterviewAnswer> RoInterviewAnswers { get; set; }
        public virtual ICollection<RoInterviewStep> RoInterviewSteps { get; set; }
    }
}
