using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица токенов
    /// </summary>
    public partial class RoToken
    {
        public RoToken()
        {
            Gates = new HashSet<RoGate>();
        }

        /// <summary>
        /// Приложение
        /// </summary>
        public int? ApplicationId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int TokenTypeId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public string Value { get; set; } = null!;
        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime InitialTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid TokenId { get; set; }
        /// <summary>
        /// Время жизни в секундах
        /// </summary>
        public int LifeTime { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int? ProductId { get; set; }

        public virtual RoApplication? Application { get; set; }
        public virtual RoProduct? Product { get; set; }
        public virtual RoTokenType TokenType { get; set; } = null!;
        public virtual RoUser? User { get; set; }

        public virtual ICollection<RoGate> Gates { get; set; }
    }
}
