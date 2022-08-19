using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица логирования переноса заявлений
    /// </summary>
    public partial class RoRegRequestTransferLog
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RegRequestTransferId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Предыдущий офис
        /// </summary>
        public int PreviousOfficeId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }

        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoOffice PreviousOffice { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
