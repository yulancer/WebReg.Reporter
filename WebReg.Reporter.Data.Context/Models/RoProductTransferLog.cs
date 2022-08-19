using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица логирования переноса продуктов
    /// </summary>
    public partial class RoProductTransferLog
    {
        public RoProductTransferLog()
        {
            RoTransferTariffLogs = new HashSet<RoTransferTariffLog>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductTransferId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
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
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
        public virtual ICollection<RoTransferTariffLog> RoTransferTariffLogs { get; set; }
    }
}
