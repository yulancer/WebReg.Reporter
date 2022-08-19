using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов документов для отправки в ПФР
    /// </summary>
    public partial class RoPfrSchemeType
    {
        public RoPfrSchemeType()
        {
            RoPfrLayoutSchemes = new HashSet<RoPfrLayoutScheme>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PfrSchemeTypeId { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string? PfrSchemeTypeName { get; set; }
        /// <summary>
        /// Категория Письма
        /// </summary>
        public string? LetterCategory { get; set; }

        public virtual ICollection<RoPfrLayoutScheme> RoPfrLayoutSchemes { get; set; }
    }
}
