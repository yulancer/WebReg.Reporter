using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний получателей продуктов
    /// </summary>
    public partial class RoMercuryRecipientStep
    {
        /// <summary>
        /// Получатель
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int MercuryId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string? PackId { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }

        public virtual RoProduct Mercury { get; set; } = null!;
        public virtual RoRecipient Recipient { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
