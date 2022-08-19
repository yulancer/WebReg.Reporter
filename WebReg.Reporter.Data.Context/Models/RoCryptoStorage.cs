using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица криптографических хранилищ
    /// </summary>
    public partial class RoCryptoStorage
    {
        public RoCryptoStorage()
        {
            RoCryptoStorageKeys = new HashSet<RoCryptoStorageKey>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CryptoStorageId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CryptoStorageName { get; set; } = null!;
        /// <summary>
        /// Адрес
        /// </summary>
        public string RemoteAddress { get; set; } = null!;
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int ProviderId { get; set; }
        public bool? IsDefault { get; set; }

        public virtual RoProvider Provider { get; set; } = null!;
        public virtual ICollection<RoCryptoStorageKey> RoCryptoStorageKeys { get; set; }
    }
}
