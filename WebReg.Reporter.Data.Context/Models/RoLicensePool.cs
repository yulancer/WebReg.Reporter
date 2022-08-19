using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица пулов лицензий
    /// </summary>
    public partial class RoLicensePool
    {
        public RoLicensePool()
        {
            RoLicensePoolSteps = new HashSet<RoLicensePoolStep>();
            Contracts = new HashSet<RoContract>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int LicenseId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int LicenseTypeId { get; set; }
        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string RegistrationNumber { get; set; } = null!;
        /// <summary>
        /// ПИН код
        /// </summary>
        public string? PinCode { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoLicenseType LicenseType { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoLicenseDetail RoLicenseDetail { get; set; } = null!;
        public virtual ICollection<RoLicensePoolStep> RoLicensePoolSteps { get; set; }

        public virtual ICollection<RoContract> Contracts { get; set; }
    }
}
