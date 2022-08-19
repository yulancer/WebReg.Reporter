using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица регионов пользователей для потенциальных клиентов
    /// </summary>
    public partial class RoPotentialAbonentUserRegion
    {
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreationTime { get; set; }

        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
