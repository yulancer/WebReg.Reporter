using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек новости
    /// </summary>
    public partial class RoNewsSetting
    {
        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;

        public virtual RoNews News { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
