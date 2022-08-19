using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица видов объектов для обновления
    /// </summary>
    public partial class RoEntityType
    {
        public RoEntityType()
        {
            RoGateUpdaters = new HashSet<RoGateUpdater>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int EntityTypeId { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string EntityTypeName { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<RoGateUpdater> RoGateUpdaters { get; set; }
    }
}
