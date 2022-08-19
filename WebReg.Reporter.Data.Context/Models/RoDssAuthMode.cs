using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица режимов аутентификации пользователей DSS
    /// </summary>
    public partial class RoDssAuthMode
    {
        public RoDssAuthMode()
        {
            RoDssUsers = new HashSet<RoDssUser>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ModeId { get; set; }
        /// <summary>
        /// Название режима
        /// </summary>
        public string? ModeName { get; set; }

        public virtual ICollection<RoDssUser> RoDssUsers { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
