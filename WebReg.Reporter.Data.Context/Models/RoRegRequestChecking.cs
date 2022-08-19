using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица проверок для заявлений
    /// </summary>
    public partial class RoRegRequestChecking
    {
        public RoRegRequestChecking()
        {
            RoRegRequestCheckingSteps = new HashSet<RoRegRequestCheckingStep>();
            RoRegRequestPassportCheckings = new HashSet<RoRegRequestPassportChecking>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CheckingId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Тип проверки
        /// </summary>
        public int CheckingTypeId { get; set; }
        /// <summary>
        /// Дата проверки
        /// </summary>
        public DateTime CheckingTime { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int? MemberId { get; set; }
        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public Guid? TaskId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Содержание проверки
        /// </summary>
        public int? ContentId { get; set; }

        public virtual RoCheckingType CheckingType { get; set; } = null!;
        public virtual RoFile? Content { get; set; }
        public virtual RoRegRequestMember? Member { get; set; }
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoRegRequestCheckingStep> RoRegRequestCheckingSteps { get; set; }
        public virtual ICollection<RoRegRequestPassportChecking> RoRegRequestPassportCheckings { get; set; }
    }
}
