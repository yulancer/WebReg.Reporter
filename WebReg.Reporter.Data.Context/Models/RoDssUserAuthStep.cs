using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний мобильной аутентификации пользователей DSS
    /// </summary>
    public partial class RoDssUserAuthStep
    {
        public int Id { get; set; }
        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int DssUserId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int? AuthStepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoStep? AuthStep { get; set; }
        public virtual RoDssUser DssUser { get; set; } = null!;
    }
}
