using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица списков анулированных сертификатов
    /// </summary>
    public partial class RoCrl
    {
        public RoCrl()
        {
            RoCrlLinks = new HashSet<RoCrlLink>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CrlId { get; set; }
        /// <summary>
        /// Идентификатор ключа издателя
        /// </summary>
        public string AuthorityKeyId { get; set; } = null!;
        /// <summary>
        /// Файл
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// Дата текущего обновления
        /// </summary>
        public DateTime ThisUpdate { get; set; }
        /// <summary>
        /// Дата следующего обновления
        /// </summary>
        public DateTime NextUpdate { get; set; }
        /// <summary>
        /// Дата обработки списка отзывов
        /// </summary>
        public DateTime? ProcessingDate { get; set; }

        public virtual ICollection<RoCrlLink> RoCrlLinks { get; set; }
    }
}
