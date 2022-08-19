using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица групп пользователей DSS
    /// </summary>
    public partial class RoDssUserGroup
    {
        public RoDssUserGroup()
        {
            RoDssUsers = new HashSet<RoDssUser>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string GroupName { get; set; } = null!;
        /// <summary>
        /// Период действия лицензии
        /// </summary>
        public int LicenseValidity { get; set; }
        /// <summary>
        /// Единицы времени лицензии
        /// </summary>
        public int ValidityUnitId { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Группа по умолчанию
        /// </summary>
        public bool? IsDefault { get; set; }

        public virtual RoDss Dss { get; set; } = null!;
        public virtual RoUnit ValidityUnit { get; set; } = null!;
        public virtual ICollection<RoDssUser> RoDssUsers { get; set; }
    }
}
