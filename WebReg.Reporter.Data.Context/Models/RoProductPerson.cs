using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сотрудников продукта
    /// </summary>
    public partial class RoProductPerson
    {
        public RoProductPerson()
        {
            RoContactPeople = new HashSet<RoContactPerson>();
            RoDssAuths = new HashSet<RoDssAuth>();
            RoProductCheckings = new HashSet<RoProductChecking>();
            RoProductDocs = new HashSet<RoProductDoc>();
            RoProductPersonKeys = new HashSet<RoProductPersonKey>();
            RoProductPersonSteps = new HashSet<RoProductPersonStep>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
            RoServices = new HashSet<RoService>();
            Ekus = new HashSet<RoEku>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductPersonId { get; set; }
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int AbonentPersonId { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public int? KeyId { get; set; }
        /// <summary>
        /// Квалификация подписи
        /// </summary>
        public int? SignQualificationId { get; set; }
        /// <summary>
        /// Шифровальщик
        /// </summary>
        public bool? Encrypt { get; set; }
        /// <summary>
        /// Онлайн
        /// </summary>
        public bool? IonOnline { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Подписант
        /// </summary>
        public bool? Signer { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Тип рег-файла
        /// </summary>
        public int? RegFileTypeId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }
        /// <summary>
        /// Резервный ключ
        /// </summary>
        public int? ReserveKeyId { get; set; }
        /// <summary>
        /// Идентификатор пользователя DSS в БД
        /// </summary>
        public int? DssUserId { get; set; }
        /// <summary>
        /// ГУИД владельца ЭЦП
        /// </summary>
        public Guid ProductPersonGuid { get; set; }
        /// <summary>
        /// Это доверенное лицо
        /// </summary>
        public bool? IsTrusted { get; set; }
        /// <summary>
        /// Сотрудник имеет роль Администратор
        /// </summary>
        public bool? IsAdministrator { get; set; }

        public virtual RoAbonentPerson AbonentPerson { get; set; } = null!;
        public virtual RoDssUser? DssUser { get; set; }
        public virtual RoKey? Key { get; set; }
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoProductType ProductType { get; set; } = null!;
        public virtual RoRegFileType? RegFileType { get; set; }
        public virtual RoKey? ReserveKey { get; set; }
        public virtual RoSignQualification? SignQualification { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoStorageType? StorageType { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoContactPerson> RoContactPeople { get; set; }
        public virtual ICollection<RoDssAuth> RoDssAuths { get; set; }
        public virtual ICollection<RoProductChecking> RoProductCheckings { get; set; }
        public virtual ICollection<RoProductDoc> RoProductDocs { get; set; }
        public virtual ICollection<RoProductPersonKey> RoProductPersonKeys { get; set; }
        public virtual ICollection<RoProductPersonStep> RoProductPersonSteps { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
        public virtual ICollection<RoService> RoServices { get; set; }

        public virtual ICollection<RoEku> Ekus { get; set; }
    }
}
