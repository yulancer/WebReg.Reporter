using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ключей криптографического хранилища
    /// </summary>
    public partial class RoCryptoStorageKey
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CryptoStorageKeyId { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public int KeyId { get; set; }
        /// <summary>
        /// Хранилище
        /// </summary>
        public int CryptoStorageId { get; set; }

        public virtual RoCryptoStorage CryptoStorage { get; set; } = null!;
        public virtual RoKey Key { get; set; } = null!;
    }
}
