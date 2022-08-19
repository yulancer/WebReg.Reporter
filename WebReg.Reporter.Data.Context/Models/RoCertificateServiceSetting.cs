using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCertificateServiceSetting
    {
        /// <summary>
        /// Ид. сервиса
        /// </summary>
        public int CertificateServiceId { get; set; }
        /// <summary>
        /// Настройка
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Значение настройки
        /// </summary>
        public string? Value { get; set; }

        public virtual RoCertificateService CertificateService { get; set; } = null!;
        public virtual RoSetting Setting { get; set; } = null!;
    }
}
