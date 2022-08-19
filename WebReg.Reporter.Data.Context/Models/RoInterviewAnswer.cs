using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ответов
    /// </summary>
    public partial class RoInterviewAnswer
    {
        public RoInterviewAnswer()
        {
            Agents = new HashSet<RoAgent>();
            Users = new HashSet<RoUser>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AnswerId { get; set; }
        /// <summary>
        /// Опрос
        /// </summary>
        public int InterviewId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string AnswerValue { get; set; } = null!;

        public virtual RoInterview Interview { get; set; } = null!;

        public virtual ICollection<RoAgent> Agents { get; set; }
        public virtual ICollection<RoUser> Users { get; set; }
    }
}
