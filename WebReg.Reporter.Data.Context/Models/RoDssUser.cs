using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица пользователей DSS
    /// </summary>
    public partial class RoDssUser
    {
        public RoDssUser()
        {
            RoDssAuthKeys = new HashSet<RoDssAuthKey>();
            RoDssAuths = new HashSet<RoDssAuth>();
            RoDssUserAuthSteps = new HashSet<RoDssUserAuthStep>();
            RoProductPeople = new HashSet<RoProductPerson>();
            RoProductPersonKeys = new HashSet<RoProductPersonKey>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// Продукт пользователя
        /// </summary>
        public int? ProductId { get; set; }
        /// <summary>
        /// Номер мобильного телефона
        /// </summary>
        public string? MobilePhone { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Режим аутентификации
        /// </summary>
        public int AuthModeId { get; set; }
        /// <summary>
        /// Тип контакта для аутентификации
        /// </summary>
        public int? AuthContactTypeId { get; set; }
        /// <summary>
        /// QR-код
        /// </summary>
        public int? QrcodeFileId { get; set; }
        /// <summary>
        /// Дата окончания действия кода
        /// </summary>
        public DateTime? QrcodeEndDate { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }
        /// <summary>
        /// Идентификатор пользователя в ЦИ
        /// </summary>
        public Guid? StsUserId { get; set; }
        /// <summary>
        /// Группа пользователей DSS
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Состояние аутентификации
        /// </summary>
        public int? AuthStepId { get; set; }
        /// <summary>
        /// Дата последней инициализации мобильной аутентификации
        /// </summary>
        public DateTime? LastInitialTime { get; set; }
        /// <summary>
        /// Дата следующей проверки на отключение мобильной аутентификации
        /// </summary>
        public DateTime? NextCheckTime { get; set; }
        /// <summary>
        /// Время активации ключа в myDSS
        /// </summary>
        public DateTime? InstallDate { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual RoContactType? AuthContactType { get; set; }
        public virtual RoDssAuthMode AuthMode { get; set; } = null!;
        public virtual RoStep? AuthStep { get; set; }
        public virtual RoDss Dss { get; set; } = null!;
        public virtual RoDssUserGroup? Group { get; set; }
        public virtual RoFile? QrcodeFile { get; set; }
        public virtual ICollection<RoDssAuthKey> RoDssAuthKeys { get; set; }
        public virtual ICollection<RoDssAuth> RoDssAuths { get; set; }
        public virtual ICollection<RoDssUserAuthStep> RoDssUserAuthSteps { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
        public virtual ICollection<RoProductPersonKey> RoProductPersonKeys { get; set; }
    }
}
