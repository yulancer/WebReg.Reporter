using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний опросов
    /// </summary>
    public partial class RoInterviewStep
    {
        /// <summary>
        /// Опрос
        /// </summary>
        public int InterviewId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoInterview Interview { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
