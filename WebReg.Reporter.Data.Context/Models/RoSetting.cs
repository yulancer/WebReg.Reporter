using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица настроек
    /// </summary>
    public partial class RoSetting
    {
        public RoSetting()
        {
            RoAgentSettings = new HashSet<RoAgentSetting>();
            RoApplicationSettings = new HashSet<RoApplicationSetting>();
            RoCaSettings = new HashSet<RoCaSetting>();
            RoCertificateServiceSettings = new HashSet<RoCertificateServiceSetting>();
            RoGateSettings = new HashSet<RoGateSetting>();
            RoNewsSettings = new HashSet<RoNewsSetting>();
            RoOfdPinSettings = new HashSet<RoOfdPinSetting>();
            RoOfficeSettings = new HashSet<RoOfficeSetting>();
            RoUserSettings = new HashSet<RoUserSetting>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string SettingName { get; set; } = null!;
        /// <summary>
        /// Тип значения
        /// </summary>
        public int ValueTypeId { get; set; }

        public virtual RoValueType ValueType { get; set; } = null!;
        public virtual ICollection<RoAgentSetting> RoAgentSettings { get; set; }
        public virtual ICollection<RoApplicationSetting> RoApplicationSettings { get; set; }
        public virtual ICollection<RoCaSetting> RoCaSettings { get; set; }
        public virtual ICollection<RoCertificateServiceSetting> RoCertificateServiceSettings { get; set; }
        public virtual ICollection<RoGateSetting> RoGateSettings { get; set; }
        public virtual ICollection<RoNewsSetting> RoNewsSettings { get; set; }
        public virtual ICollection<RoOfdPinSetting> RoOfdPinSettings { get; set; }
        public virtual ICollection<RoOfficeSetting> RoOfficeSettings { get; set; }
        public virtual ICollection<RoUserSetting> RoUserSettings { get; set; }
    }
}
