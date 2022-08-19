using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с сообщениями
    /// </summary>
    public partial class RoRegRequestComment
    {
        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        public int CommentId { get; set; }
        /// <summary>
        /// Идентификатор лида
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string? CommentText { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
