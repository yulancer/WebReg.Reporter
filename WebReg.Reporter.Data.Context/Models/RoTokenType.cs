using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов токенов
    /// </summary>
    public partial class RoTokenType
    {
        public RoTokenType()
        {
            RoTokens = new HashSet<RoToken>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int TokenTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TokenTypeName { get; set; } = null!;
        /// <summary>
        /// Время жизни в секундах
        /// </summary>
        public int LifeTime { get; set; }

        public virtual ICollection<RoToken> RoTokens { get; set; }
    }
}
