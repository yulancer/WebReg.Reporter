using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ключей сотрудников продукта
    /// </summary>
    public partial class RoProductPersonKey
    {
        public RoProductPersonKey()
        {
            RoKeyPermissions = new HashSet<RoKeyPermission>();
        }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public int ProductPersonId { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public int KeyId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// Флаг резервного ключа
        /// </summary>
        public bool Reserve { get; set; }
        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int? DssUserId { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PersonKeyId { get; set; }
        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }

        public virtual RoDssUser? DssUser { get; set; }
        public virtual RoKey Key { get; set; } = null!;
        public virtual RoProductPerson ProductPerson { get; set; } = null!;
        public virtual RoStorageType? StorageType { get; set; }
        public virtual ICollection<RoKeyPermission> RoKeyPermissions { get; set; }
    }
}
