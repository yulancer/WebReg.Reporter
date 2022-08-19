using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек офисов
    /// </summary>
    public partial class RoOfficeSetting
    {
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;
        /// <summary>
        /// Время начала действия
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Время окончания действия
        /// </summary>
        public DateTime? EndTime { get; set; }

        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
