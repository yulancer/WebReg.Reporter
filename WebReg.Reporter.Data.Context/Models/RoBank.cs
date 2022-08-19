using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Справочник банков
    /// </summary>
    public partial class RoBank
    {
        /// <summary>
        /// БИК
        /// </summary>
        public string Bic { get; set; } = null!;
        /// <summary>
        /// Наименование банка
        /// </summary>
        public string BankName { get; set; } = null!;
        /// <summary>
        /// Корреспондентский счёт
        /// </summary>
        public string? CorrespondentAccount { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateOnly? OffDate { get; set; }
    }
}
