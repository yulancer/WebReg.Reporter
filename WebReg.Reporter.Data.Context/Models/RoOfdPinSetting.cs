using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdPinSetting
    {
        /// <summary>
        /// Пин ид.
        /// </summary>
        public int PinId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string SettingValue { get; set; } = null!;

        public virtual RoOfdPin Pin { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
