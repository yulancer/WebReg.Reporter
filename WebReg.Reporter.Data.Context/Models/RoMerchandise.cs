using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public partial class RoMerchandise
    {
        public RoMerchandise()
        {
            RoAgentMerchandises = new HashSet<RoAgentMerchandise>();
            RoBulkSkziLicenseUploadTasks = new HashSet<RoBulkSkziLicenseUploadTask>();
            RoMerchandiseBills = new HashSet<RoMerchandiseBill>();
            RoSkziLicenses = new HashSet<RoSkziLicense>();
        }

        /// <summary>
        /// Ид в базе 1С
        /// </summary>
        public string? MerchandiseSid { get; set; }
        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string? ShortName { get; set; }
        /// <summary>
        /// Полное наименование
        /// </summary>
        public string? FullName { get; set; }
        /// <summary>
        /// Код единицы измерения
        /// </summary>
        public int? MeasureUnitCode { get; set; }
        /// <summary>
        /// Краткое наименование единицы измерения
        /// </summary>
        public string? UnitShortName { get; set; }
        /// <summary>
        /// Полное наименование единицы измерения
        /// </summary>
        public string? UnitFullName { get; set; }
        public int MerchandiseId { get; set; }
        /// <summary>
        /// Минимальное количество компаний
        /// </summary>
        public int? MinCount { get; set; }
        /// <summary>
        /// Максимальное количество компаний
        /// </summary>
        public int? MaxCount { get; set; }
        public decimal Price { get; set; }
        public decimal NdsPercent { get; set; }
        /// <summary>
        /// Вес(кг)
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int? MerchandiseTypeId { get; set; }
        /// <summary>
        /// Размер вознаграждения
        /// </summary>
        public int Reward { get; set; }
        public DateTime? OffTime { get; set; }

        public virtual RoMerchandiseType? MerchandiseType { get; set; }
        public virtual ICollection<RoAgentMerchandise> RoAgentMerchandises { get; set; }
        public virtual ICollection<RoBulkSkziLicenseUploadTask> RoBulkSkziLicenseUploadTasks { get; set; }
        public virtual ICollection<RoMerchandiseBill> RoMerchandiseBills { get; set; }
        public virtual ICollection<RoSkziLicense> RoSkziLicenses { get; set; }
    }
}
