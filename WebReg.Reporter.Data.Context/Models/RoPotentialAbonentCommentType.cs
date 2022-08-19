using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов сообщений
    /// </summary>
    public partial class RoPotentialAbonentCommentType
    {
        public RoPotentialAbonentCommentType()
        {
            RoPotentialAbonentComments = new HashSet<RoPotentialAbonentComment>();
        }

        /// <summary>
        /// Идентификатор типа сообщения
        /// </summary>
        public int CommentTypeId { get; set; }
        /// <summary>
        /// Наименование типа сообщения
        /// </summary>
        public string CommentName { get; set; } = null!;

        public virtual ICollection<RoPotentialAbonentComment> RoPotentialAbonentComments { get; set; }
    }
}
