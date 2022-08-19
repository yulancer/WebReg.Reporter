using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица подписанных документов для Сбербанка
    /// </summary>
    public partial class RoSberbankDocument
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DocId { get; set; }
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public Guid DocGuid { get; set; }
        /// <summary>
        /// Хеш от данных
        /// </summary>
        public byte[] Hash { get; set; } = null!;
        /// <summary>
        /// Файл подписи
        /// </summary>
        public int? SignId { get; set; }
    }
}
