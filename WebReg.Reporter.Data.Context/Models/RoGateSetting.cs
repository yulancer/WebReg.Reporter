using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек гейстов
    /// </summary>
    public partial class RoGateSetting
    {
        /// <summary>
        /// Гейт
        /// </summary>
        public Guid GateId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;

        public virtual RoGate Gate { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
