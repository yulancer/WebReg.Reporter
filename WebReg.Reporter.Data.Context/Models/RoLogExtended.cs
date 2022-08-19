using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Расширенная таблица логов
    /// </summary>
    public partial class RoLogExtended
    {
        public RoLogExtended()
        {
            RoLogExtendedDetails = new HashSet<RoLogExtendedDetail>();
        }

        /// <summary>
        /// ID таблицы
        /// </summary>
        public int LogId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// ID изменяемой сущности
        /// </summary>
        public int EntityId { get; set; }
        /// <summary>
        /// Изменяемая таблица
        /// </summary>
        public string TableName { get; set; } = null!;
        /// <summary>
        /// Тип операции
        /// </summary>
        public int LogTypeId { get; set; }
        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Логгируемая операция
        /// </summary>
        public int OperationId { get; set; }

        public virtual RoLogType LogType { get; set; } = null!;
        public virtual RoLogExtendedOperationDesc Operation { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
        public virtual ICollection<RoLogExtendedDetail> RoLogExtendedDetails { get; set; }
    }
}
