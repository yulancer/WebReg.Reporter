using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица аудита по колонкам
    /// </summary>
    public partial class RoAuditField
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// Таблица
        /// </summary>
        public string TableName { get; set; } = null!;
        /// <summary>
        /// Колонка
        /// </summary>
        public string? FieldName { get; set; }
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public string? PkName { get; set; }
        /// <summary>
        /// Значение ключа
        /// </summary>
        public string? PkValue { get; set; }
        /// <summary>
        /// Действие
        /// </summary>
        public char Action { get; set; }
        /// <summary>
        /// Исходное значение
        /// </summary>
        public string? OriginalValue { get; set; }
        /// <summary>
        /// Новое значение
        /// </summary>
        public string? NewValue { get; set; }
    }
}
