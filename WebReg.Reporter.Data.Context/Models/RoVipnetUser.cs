using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица пользователей ViPNet
    /// </summary>
    public partial class RoVipnetUser
    {
        public RoVipnetUser()
        {
            RoKeys = new HashSet<RoKey>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public string VipnetUserId { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string? VipnetUserName { get; set; }
        /// <summary>
        /// Сетевой узел
        /// </summary>
        public string VipnetNodeId { get; set; } = null!;

        public virtual RoVipnetNode VipnetNode { get; set; } = null!;
        public virtual ICollection<RoKey> RoKeys { get; set; }
    }
}
