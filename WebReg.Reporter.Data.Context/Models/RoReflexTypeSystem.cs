using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица связи типов БД рефлекса с системами
    /// </summary>
    public partial class RoReflexTypeSystem
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public int ReflexTypeSystemId { get; set; }
        /// <summary>
        /// Тип БД рефлекс
        /// </summary>
        public int ReflexTypeId { get; set; }
        /// <summary>
        /// Система
        /// </summary>
        public int SystemId { get; set; }

        public virtual RoReflexType ReflexType { get; set; } = null!;
        public virtual RoUpdateSystem System { get; set; } = null!;
    }
}
