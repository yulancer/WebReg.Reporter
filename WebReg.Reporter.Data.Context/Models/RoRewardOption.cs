using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица вознаграждений за опции
    /// </summary>
    public partial class RoRewardOption
    {
        /// <summary>
        /// Схема
        /// </summary>
        public int SchemeId { get; set; }
        /// <summary>
        /// Атрибут
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal? PercentReward { get; set; }

        public virtual RoAttribute Attribute { get; set; } = null!;
        public virtual RoAgentScheme Scheme { get; set; } = null!;
    }
}
