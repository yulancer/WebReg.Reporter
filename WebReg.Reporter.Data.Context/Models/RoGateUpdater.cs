using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица обновлений объектов
    /// </summary>
    public partial class RoGateUpdater
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int GateUpdaterId { get; set; }
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }
        /// <summary>
        /// Тип объекта
        /// </summary>
        public int EntityTypeId { get; set; }
        /// <summary>
        /// Гуид объекта
        /// </summary>
        public Guid EntityGuid { get; set; }
        /// <summary>
        /// Время обновления
        /// </summary>
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// Время подтверждения обновления
        /// </summary>
        public DateTime? ConfirmTime { get; set; }

        public virtual RoEntityType EntityType { get; set; } = null!;
        public virtual RoGate Gate { get; set; } = null!;
    }
}
