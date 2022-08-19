using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица приложений
    /// </summary>
    public partial class RoApplication
    {
        public RoApplication()
        {
            RoApplicationSettings = new HashSet<RoApplicationSetting>();
            RoApplicationSteps = new HashSet<RoApplicationStep>();
            RoLogV2s = new HashSet<RoLogV2>();
            RoLogs = new HashSet<RoLog>();
            RoOperationLogs = new HashSet<RoOperationLog>();
            RoProcessingProducts = new HashSet<RoProcessingProduct>();
            RoTokens = new HashSet<RoToken>();
            RoTransitions = new HashSet<RoTransition>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ApplicationName { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoApplicationSetting> RoApplicationSettings { get; set; }
        public virtual ICollection<RoApplicationStep> RoApplicationSteps { get; set; }
        public virtual ICollection<RoLogV2> RoLogV2s { get; set; }
        public virtual ICollection<RoLog> RoLogs { get; set; }
        public virtual ICollection<RoOperationLog> RoOperationLogs { get; set; }
        public virtual ICollection<RoProcessingProduct> RoProcessingProducts { get; set; }
        public virtual ICollection<RoToken> RoTokens { get; set; }
        public virtual ICollection<RoTransition> RoTransitions { get; set; }
    }
}
