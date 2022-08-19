using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица данных по личному кабинету
    /// </summary>
    public partial class RoPortalAccount
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Тип личного кабинета
        /// </summary>
        public int PortalTypeId { get; set; }
        /// <summary>
        /// Идентификатор записи на портале
        /// </summary>
        public string? AccountId { get; set; }

        public virtual RoPortalType PortalType { get; set; } = null!;
        public virtual RoProduct Product { get; set; } = null!;
    }
}
