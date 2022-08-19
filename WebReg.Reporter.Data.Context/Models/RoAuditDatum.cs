using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица аудита данных
    /// </summary>
    public partial class RoAuditDatum
    {
        /// <summary>
        /// Схема
        /// </summary>
        public string SchemaName { get; set; } = null!;
        /// <summary>
        /// Таблица
        /// </summary>
        public string TableName { get; set; } = null!;
        /// <summary>
        /// Пользователь
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Действие
        /// </summary>
        public string Action { get; set; } = null!;
        /// <summary>
        /// Исходные данные
        /// </summary>
        public string? OriginalData { get; set; }
        /// <summary>
        /// Новые данные
        /// </summary>
        public string? NewData { get; set; }
        /// <summary>
        /// Запрос
        /// </summary>
        public string? Query { get; set; }
    }
}
