using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица запросов для отчетов
    /// </summary>
    public partial class RoReportQuery
    {
        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public int ReportQueryId { get; set; }
        /// <summary>
        /// SQL-запрос
        /// </summary>
        public string SqlQuery { get; set; } = null!;
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
    }
}
