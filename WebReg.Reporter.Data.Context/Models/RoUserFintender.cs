using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица пользователей финтендера
    /// </summary>
    public partial class RoUserFintender
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Администратор
        /// </summary>
        public bool IsAdmin { get; set; }

        public virtual RoUser User { get; set; } = null!;
    }
}
