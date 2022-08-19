using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица логов изменений статусов кодов аутентификации
    /// </summary>
    public partial class RoDssAuthKeyStep
    {
        /// <summary>
        /// Идентификатор кода аутентификации
        /// </summary>
        public int DssAuthKeyId { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoDssAuthKey DssAuthKey { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
