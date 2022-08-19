using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица переходов
    /// </summary>
    public partial class RoTransition
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TransitionId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Следующее состояние
        /// </summary>
        public int NextStepId { get; set; }
        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// Тип объекта
        /// </summary>
        public int ObjectTypeId { get; set; }
        /// <summary>
        /// Объект
        /// </summary>
        public int? ObjectId { get; set; }
        /// <summary>
        /// Условие
        /// </summary>
        public int ConditionId { get; set; }
        /// <summary>
        /// Приоритет
        /// </summary>
        public int? Priority { get; set; }

        public virtual RoApplication Application { get; set; } = null!;
        public virtual RoCondition Condition { get; set; } = null!;
        public virtual RoStep NextStep { get; set; } = null!;
        public virtual RoObject? Object { get; set; }
        public virtual RoObjectType ObjectType { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
