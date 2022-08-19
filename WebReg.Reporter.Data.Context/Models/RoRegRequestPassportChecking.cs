using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица проверки данных паспорта для заявлений
    /// </summary>
    public partial class RoRegRequestPassportChecking
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PassportCheckingId { get; set; }
        /// <summary>
        /// Проверка скана паспорта
        /// </summary>
        public int RegRequestCheckingId { get; set; }
        /// <summary>
        /// Тип данных паспорта
        /// </summary>
        public int PassportDataTypeId { get; set; }
        /// <summary>
        /// Данные паспорта со скана
        /// </summary>
        public string? PassportDataFromScan { get; set; }
        /// <summary>
        /// Данные паспорта из заявки
        /// </summary>
        public string? PassportDataFromRequest { get; set; }
        /// <summary>
        /// Данные совпадают
        /// </summary>
        public bool IsEquals { get; set; }

        public virtual RoPassportDataType PassportDataType { get; set; } = null!;
        public virtual RoRegRequestChecking RegRequestChecking { get; set; } = null!;
    }
}
