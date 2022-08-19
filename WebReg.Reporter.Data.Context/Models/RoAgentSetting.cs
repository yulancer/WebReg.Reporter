using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек агентов
    /// </summary>
    public partial class RoAgentSetting
    {
        /// <summary>
        /// Агент
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;
        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Время окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
