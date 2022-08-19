using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица точек
    /// </summary>
    public partial class RoPoint
    {
        public RoPoint()
        {
            RoAgentSchemes = new HashSet<RoAgentScheme>();
            RoPointSteps = new HashSet<RoPointStep>();
            RoPointUses = new HashSet<RoPointUse>();
            RoPointZones = new HashSet<RoPointZone>();
            RoProducts = new HashSet<RoProduct>();
            RoRegRequestIdentPoints = new HashSet<RoRegRequest>();
            RoRegRequestTransferPoints = new HashSet<RoRegRequest>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PointId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string PointName { get; set; } = null!;
        /// <summary>
        /// Гуид
        /// </summary>
        public Guid PointGuid { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public int? AddressId { get; set; }
        /// <summary>
        /// График работы
        /// </summary>
        public string? Schedule { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Широта
        /// </summary>
        public decimal? Latitude { get; set; }
        /// <summary>
        /// Долгота
        /// </summary>
        public decimal? Longitude { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoAddr? Address { get; set; }
        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoAgentScheme> RoAgentSchemes { get; set; }
        public virtual ICollection<RoPointStep> RoPointSteps { get; set; }
        public virtual ICollection<RoPointUse> RoPointUses { get; set; }
        public virtual ICollection<RoPointZone> RoPointZones { get; set; }
        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequestIdentPoints { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequestTransferPoints { get; set; }
    }
}
