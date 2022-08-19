using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoLicense
    {
        public RoLicense()
        {
            RoLicenseSteps = new HashSet<RoLicenseStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int LicenseId { get; set; }
        /// <summary>
        /// Ссылка на продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Ссылка на тип лицензии
        /// </summary>
        public int LicenseTypeId { get; set; }
        /// <summary>
        /// Гуид лицензии
        /// </summary>
        public Guid LicenseGuid { get; set; }
        /// <summary>
        /// Флаг актуальности
        /// </summary>
        public bool IsActual { get; set; }
        /// <summary>
        /// Флаг первой лицензии
        /// </summary>
        public bool IsPrimary { get; set; }
        /// <summary>
        /// Время начала действия лицензии
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Время окончания действия лицензии
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Время ожидания
        /// </summary>
        public int? TimeLimit { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoLicenseType LicenseType { get; set; } = null!;
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoLicenseStep> RoLicenseSteps { get; set; }
    }
}
