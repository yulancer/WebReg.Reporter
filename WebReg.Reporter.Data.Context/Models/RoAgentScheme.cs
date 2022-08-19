using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица партнерских схем
    /// </summary>
    public partial class RoAgentScheme
    {
        public RoAgentScheme()
        {
            RoCaServices = new HashSet<RoCaService>();
            RoRewardOptions = new HashSet<RoRewardOption>();
            Bonus = new HashSet<RoBonu>();
            Offices = new HashSet<RoOffice>();
            Plans = new HashSet<RoPlan>();
        }

        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Уровень
        /// </summary>
        public int LevelId { get; set; }
        /// <summary>
        /// Дилер
        /// </summary>
        public bool? Dealer { get; set; }
        /// <summary>
        /// Принадлежность
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal? PercentReward { get; set; }
        /// <summary>
        /// Точка выдачи
        /// </summary>
        public int? TransferPointId { get; set; }
        /// <summary>
        /// Прайс
        /// </summary>
        public int? PriceId { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int SchemeId { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int? RegionId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoAgentLevel Level { get; set; } = null!;
        public virtual RoAgent? Parent { get; set; }
        public virtual RoPrice? Price { get; set; }
        public virtual RoProductType ProductType { get; set; } = null!;
        public virtual RoRegion? Region { get; set; }
        public virtual RoPoint? TransferPoint { get; set; }
        public virtual ICollection<RoCaService> RoCaServices { get; set; }
        public virtual ICollection<RoRewardOption> RoRewardOptions { get; set; }

        public virtual ICollection<RoBonu> Bonus { get; set; }
        public virtual ICollection<RoOffice> Offices { get; set; }
        public virtual ICollection<RoPlan> Plans { get; set; }
    }
}
