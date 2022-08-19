using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица задач по импорту абонентов
    /// </summary>
    public partial class RoAbonentImportTask
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// Наименование файла
        /// </summary>
        public string TaskFileName { get; set; } = null!;
        /// <summary>
        /// Данные входного файла
        /// </summary>
        public byte[]? InputFileData { get; set; }
        /// <summary>
        /// Данные выходного файла
        /// </summary>
        public byte[]? OutputFileData { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Тип импортируемых абонентов
        /// </summary>
        public int AbonentTypeId { get; set; }
        /// <summary>
        /// Пользователь, осуществивший импорт
        /// </summary>
        public int UserId { get; set; }

        public virtual RoAbonentType AbonentType { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
