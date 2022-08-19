using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек пользователей
    /// </summary>
    public partial class RoUserSetting
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;

        public virtual RoSetting Setting { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
