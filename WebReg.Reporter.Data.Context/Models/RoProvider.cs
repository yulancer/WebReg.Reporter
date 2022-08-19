using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица криптопровайдеров
    /// </summary>
    public partial class RoProvider
    {
        public RoProvider()
        {
            RoCryptoStorages = new HashSet<RoCryptoStorage>();
            RoDsses = new HashSet<RoDss>();
            RoKeys = new HashSet<RoKey>();
            RoMemberReserveKeys = new HashSet<RoMemberReserveKey>();
            RoOffices = new HashSet<RoOffice>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int ProviderId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string ProviderName { get; set; } = null!;
        /// <summary>
        /// Тип
        /// </summary>
        public int ProviderType { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Средство ЭП
        /// </summary>
        public string SignTool { get; set; } = null!;

        public virtual ICollection<RoCryptoStorage> RoCryptoStorages { get; set; }
        public virtual ICollection<RoDss> RoDsses { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoMemberReserveKey> RoMemberReserveKeys { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
