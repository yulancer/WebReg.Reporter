using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Описание плана подключений
    /// </summary>
    public partial class RoPlanDetail
    {
        /// <summary>
        /// Идентификатор плана
        /// </summary>
        public int PlanId { get; set; }
        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Месяц
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// Минимальное значение
        /// </summary>
        public int MinValue { get; set; }
        /// <summary>
        /// Максимальное значение
        /// </summary>
        public int? MaxValue { get; set; }
        /// <summary>
        /// % вознаграждения
        /// </summary>
        public decimal PercentReward { get; set; }

        public virtual RoPlan Plan { get; set; } = null!;
    }
}
