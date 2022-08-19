using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица реквизитов лицензий
    /// </summary>
    public partial class RoLicenseDetail
    {
        /// <summary>
        /// Лицензия
        /// </summary>
        public int LicenseId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// ИТС
        /// </summary>
        public int? ItsId { get; set; }
        /// <summary>
        /// Флаг бесплатной лицензии
        /// </summary>
        public bool? IsFree { get; set; }
        /// <summary>
        /// Ид. опции ИТС
        /// </summary>
        public string? ItsOptionId { get; set; }
        /// <summary>
        /// Ид. пользователя 1С
        /// </summary>
        public string? Uin1c { get; set; }

        public virtual RoIt? Its { get; set; }
        public virtual RoLicensePool License { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
    }
}
