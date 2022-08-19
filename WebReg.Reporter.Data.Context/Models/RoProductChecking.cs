using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица проверок для продуктов
    /// </summary>
    public partial class RoProductChecking
    {
        public RoProductChecking()
        {
            RoProductCheckingSteps = new HashSet<RoProductCheckingStep>();
            RoProductPassportCheckings = new HashSet<RoProductPassportChecking>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CheckingId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
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
        public int? ProductPersonId { get; set; }
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
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoProductPerson? ProductPerson { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoProductCheckingStep> RoProductCheckingSteps { get; set; }
        public virtual ICollection<RoProductPassportChecking> RoProductPassportCheckings { get; set; }
    }
}
