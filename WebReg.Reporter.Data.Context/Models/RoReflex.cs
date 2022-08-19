using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица отражений БД на серверах
    /// </summary>
    public partial class RoReflex
    {
        public RoReflex()
        {
            RoReflexMessengers = new HashSet<RoReflexMessenger>();
            RoReflexProductTypes = new HashSet<RoReflexProductType>();
            RoReflexProducts = new HashSet<RoReflexProduct>();
            RoReflexRules = new HashSet<RoReflexRule>();
            RoReflexUseTypes = new HashSet<RoReflexUseType>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ReflexId { get; set; }
        /// <summary>
        /// Имя БД
        /// </summary>
        public string DatabaseName { get; set; } = null!;
        /// <summary>
        /// Адрес
        /// </summary>
        public string Host { get; set; } = null!;
        /// <summary>
        /// Порт
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Тестовое
        /// </summary>
        public bool? IsTest { get; set; }

        public virtual ICollection<RoReflexMessenger> RoReflexMessengers { get; set; }
        public virtual ICollection<RoReflexProductType> RoReflexProductTypes { get; set; }
        public virtual ICollection<RoReflexProduct> RoReflexProducts { get; set; }
        public virtual ICollection<RoReflexRule> RoReflexRules { get; set; }
        public virtual ICollection<RoReflexUseType> RoReflexUseTypes { get; set; }
    }
}
