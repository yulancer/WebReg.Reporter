using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица видимости для новостей
    /// </summary>
    public partial class RoNewsVisibility
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int NewsVisibilityId { get; set; }
        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int? RegionId { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int? AgentId { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public int? RoleId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// Уровень агента
        /// </summary>
        public int? AgentLevelId { get; set; }

        public virtual RoAgent? Agent { get; set; }
        public virtual RoAgentLevel? AgentLevel { get; set; }
        public virtual RoNews News { get; set; } = null!;
        public virtual RoProductType? ProductType { get; set; }
        public virtual RoRegion? Region { get; set; }
        public virtual RoRole? Role { get; set; }
    }
}
