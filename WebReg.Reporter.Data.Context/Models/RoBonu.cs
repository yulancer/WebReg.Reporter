using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица премий
    /// </summary>
    public partial class RoBonu
    {
        public RoBonu()
        {
            RoAgentRewards = new HashSet<RoAgentReward>();
            Schemes = new HashSet<RoAgentScheme>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int BonusId { get; set; }
        /// <summary>
        /// Тип премии
        /// </summary>
        public int BonusTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string BonusName { get; set; } = null!;
        /// <summary>
        /// Относительная/абсолютная
        /// </summary>
        public bool? Percent { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public decimal? BonusValue { get; set; }
        /// <summary>
        /// Минимальное количество
        /// </summary>
        public int? MinNumber { get; set; }
        /// <summary>
        /// Максимальное количество
        /// </summary>
        public int? MaxNumber { get; set; }

        public virtual RoBonusType BonusType { get; set; } = null!;
        public virtual ICollection<RoAgentReward> RoAgentRewards { get; set; }

        public virtual ICollection<RoAgentScheme> Schemes { get; set; }
    }
}
