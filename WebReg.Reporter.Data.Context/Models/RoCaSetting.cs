using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек УЦ
    /// </summary>
    public partial class RoCaSetting
    {
        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaSettingId { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
