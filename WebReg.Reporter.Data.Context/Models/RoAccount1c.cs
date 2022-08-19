using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица учетных записей ЛК 1С
    /// </summary>
    public partial class RoAccount1c
    {
        /// <summary>
        /// Идиентификатор
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Идентификационный номер пользователя 1С
        /// </summary>
        public string Uin { get; set; } = null!;
        /// <summary>
        /// Логин
        /// </summary>
        public string? Login { get; set; }
        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string? Email { get; set; }
    }
}
