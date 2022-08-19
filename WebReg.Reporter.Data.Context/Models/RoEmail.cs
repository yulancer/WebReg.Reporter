using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Электронные адреса
    /// </summary>
    public partial class RoEmail
    {
        /// <summary>
        /// Идентификатор электронного адреса
        /// </summary>
        public int EmailId { get; set; }
        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string Email { get; set; } = null!;
    }
}
