using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица продуктов в обработке
    /// </summary>
    public partial class RoProcessingProduct
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Приложение
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// Время блокировки
        /// </summary>
        public DateTime BlockTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Режим
        /// </summary>
        public int ModeId { get; set; }

        public virtual RoApplication Application { get; set; } = null!;
        public virtual RoProcessingMode Mode { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
