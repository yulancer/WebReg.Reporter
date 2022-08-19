using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Временная таблица для подтверждения наличия e-mail у пользователя
    /// </summary>
    public partial class RoUserEmailRegistered
    {
        /// <summary>
        /// идентификатор пользователя с подтверждённым e-mail
        /// </summary>
        public int UserId { get; set; }
    }
}
