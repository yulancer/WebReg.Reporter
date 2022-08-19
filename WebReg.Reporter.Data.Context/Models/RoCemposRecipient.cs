using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoCemposRecipient
    {
        /// <summary>
        /// Ид
        /// </summary>
        public Guid CemposRecipientId { get; set; }
        /// <summary>
        /// Код региона
        /// </summary>
        public string RegionCode { get; set; } = null!;
        /// <summary>
        /// Код
        /// </summary>
        public string RecipientCode { get; set; } = null!;
        /// <summary>
        /// Старый код
        /// </summary>
        public string RecipientCodeOld { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string RecipientName { get; set; } = null!;
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Завершение перехода
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}
