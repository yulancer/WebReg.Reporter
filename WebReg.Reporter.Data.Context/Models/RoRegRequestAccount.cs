using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица учетных записей заявления
    /// </summary>
    public partial class RoRegRequestAccount
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Тип учетной записи
        /// </summary>
        public int PortalTypeId { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;

        public virtual RoPortalType PortalType { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
    }
}
