using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoUserPassword
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual RoUser User { get; set; } = null!;
    }
}
