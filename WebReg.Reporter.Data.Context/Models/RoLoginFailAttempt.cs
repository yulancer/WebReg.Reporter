using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoLoginFailAttempt
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FailAttemptId { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Время попытки логина
        /// </summary>
        public DateTime AttemptDate { get; set; }
    }
}
