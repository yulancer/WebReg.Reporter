using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний лицензий в пуле
    /// </summary>
    public partial class RoLicensePoolStep
    {
        /// <summary>
        /// Лицензия
        /// </summary>
        public int LicenseId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }

        public virtual RoLicensePool License { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
    }
}
