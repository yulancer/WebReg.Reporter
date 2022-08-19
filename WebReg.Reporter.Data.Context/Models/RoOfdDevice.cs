using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Данные по аппаратуре ОФД
    /// </summary>
    public partial class RoOfdDevice
    {
        public RoOfdDevice()
        {
            RoOfdPins = new HashSet<RoOfdPin>();
        }

        /// <summary>
        /// Идентификатор аппаратуры ОФД
        /// </summary>
        public int OfdDeviceId { get; set; }
        /// <summary>
        /// Заводской номер
        /// </summary>
        public string SerialNumber { get; set; } = null!;
        /// <summary>
        /// Тип аппаратуры
        /// </summary>
        public int OfdDeviceTypeId { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Идентификатор партнера
        /// </summary>
        public int? AgentId { get; set; }
        /// <summary>
        /// Идентификатор центра продаж
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Идентификатор Астрал-ККТ
        /// </summary>
        public int? AstralKktId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? AstralKktDate { get; set; }
        /// <summary>
        /// Дата получения центром продаж
        /// </summary>
        public DateTime? ParentDate { get; set; }
        /// <summary>
        /// Дата получения партнером
        /// </summary>
        public DateTime? AgentDate { get; set; }
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }
        public DateTime LastChangeDate { get; set; }
        /// <summary>
        /// Продолжительность периода действия кода активации
        /// </summary>
        public int? ValidityLength { get; set; }
        /// <summary>
        /// Единица измерения периода действия кода активации
        /// </summary>
        public int? ValidityUnitId { get; set; }

        public virtual RoAgent? Agent { get; set; }
        public virtual RoAgent? AstralKkt { get; set; }
        public virtual RoOfdDeviceType OfdDeviceType { get; set; } = null!;
        public virtual RoAgent? Parent { get; set; }
        public virtual RoUser User { get; set; } = null!;
        public virtual RoUnit? ValidityUnit { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
    }
}
