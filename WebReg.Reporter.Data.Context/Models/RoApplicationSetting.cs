using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек приложений
    /// </summary>
    public partial class RoApplicationSetting
    {
        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;

        public virtual RoApplication Application { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
