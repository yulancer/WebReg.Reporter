using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с сообщениями
    /// </summary>
    public partial class RoPotentialAbonentComment
    {
        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        public int CommentId { get; set; }
        /// <summary>
        /// Идентификатор лида
        /// </summary>
        public int PotentialAbonentId { get; set; }
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
        /// <summary>
        /// Тип сообщения
        /// </summary>
        public int CommentTypeId { get; set; }

        public virtual RoPotentialAbonentCommentType CommentType { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
