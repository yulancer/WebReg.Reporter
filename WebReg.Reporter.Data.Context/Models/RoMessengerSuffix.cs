using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Суффиксы курьеров
    /// </summary>
    public partial class RoMessengerSuffix
    {
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Суффикс
        /// </summary>
        public string Suffix { get; set; } = null!;

        public virtual RoMessenger Messenger { get; set; } = null!;
    }
}
