using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица абонентов ИРУЦ
    /// </summary>
    public partial class RoIrucAbonent
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int IrucAbonentId { get; set; }
        /// <summary>
        /// ГУИД абонента
        /// </summary>
        public Guid AbonentGuid { get; set; }
        /// <summary>
        /// Префикс
        /// </summary>
        public string SystemPrefix { get; set; } = null!;
        /// <summary>
        /// Логин
        /// </summary>
        public string EmailLogin { get; set; } = null!;
        /// <summary>
        /// Домен СОЭД
        /// </summary>
        public string DomainSoed { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string? EmailPassword { get; set; }
    }
}
