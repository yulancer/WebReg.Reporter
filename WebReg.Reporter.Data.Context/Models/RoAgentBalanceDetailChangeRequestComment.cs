using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Комментарии по заявке на изменение позиции в сверке
    /// </summary>
    public partial class RoAgentBalanceDetailChangeRequestComment
    {
        public RoAgentBalanceDetailChangeRequestComment()
        {
            Files = new HashSet<RoFile>();
        }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        public int RequestCommentId { get; set; }
        /// <summary>
        /// Заявка на изменение позиции в сверке
        /// </summary>
        public int BalanceDetailChangeRequestId { get; set; }
        /// <summary>
        /// Текст комментария
        /// </summary>
        public string CommentText { get; set; } = null!;
        /// <summary>
        /// Время добавления комментария
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Пользователь, добавивший комментарий
        /// </summary>
        public int UserId { get; set; }

        public virtual RoAgentBalanceDetailChangeRequest BalanceDetailChangeRequest { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;

        public virtual ICollection<RoFile> Files { get; set; }
    }
}
