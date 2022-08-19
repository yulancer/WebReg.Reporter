using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// DSS
    /// </summary>
    public partial class RoDss
    {
        public RoDss()
        {
            RoDssAuthKeys = new HashSet<RoDssAuthKey>();
            RoDssAuthSystems = new HashSet<RoDssAuthSystem>();
            RoDssUserGroups = new HashSet<RoDssUserGroup>();
            RoDssUsers = new HashSet<RoDssUser>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DssId { get; set; }
        /// <summary>
        /// Наименование УЦ
        /// </summary>
        public string CaName { get; set; } = null!;
        /// <summary>
        /// ИД клиента
        /// </summary>
        public string ClientId { get; set; } = null!;
        /// <summary>
        /// Адрес
        /// </summary>
        public string DssHost { get; set; } = null!;
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int ProviderId { get; set; }
        /// <summary>
        /// OID шаблона
        /// </summary>
        public string TemplateOid { get; set; } = null!;
        /// <summary>
        /// Адрес СЭП
        /// </summary>
        public string? SignAddress { get; set; }
        /// <summary>
        /// Идентификатор ЦИ
        /// </summary>
        public string? StsId { get; set; }
        /// <summary>
        /// Идентификатор СЭП
        /// </summary>
        public string? SignId { get; set; }
        /// <summary>
        /// Внутренний идентификатор
        /// </summary>
        public string? InnerId { get; set; }
        /// <summary>
        /// Шаблон подтверждения
        /// </summary>
        public string? ConfirmTemplate { get; set; }
        /// <summary>
        /// Способ аутентификации
        /// </summary>
        public int? AuthMethod { get; set; }
        /// <summary>
        /// Способ подтверждения
        /// </summary>
        public int? ConfirmMethod { get; set; }
        /// <summary>
        /// Адрес ЛК
        /// </summary>
        public string? AccountAddress { get; set; }
        /// <summary>
        /// Используется
        /// </summary>
        public bool? Used { get; set; }
        /// <summary>
        /// Таймаут
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Версия АПИ
        /// </summary>
        public string? ApiVer { get; set; }
        /// <summary>
        /// Адрес ЦИ
        /// </summary>
        public string? StsAddress { get; set; }
        /// <summary>
        /// Адрес SVS
        /// </summary>
        public string? SvsAddress { get; set; }
        /// <summary>
        /// Открытый пользователь
        /// </summary>
        public string? EncryptUser { get; set; }
        /// <summary>
        /// Адрес криптосервиса
        /// </summary>
        public string? CsAddress { get; set; }
        /// <summary>
        /// Пароль открытого пользователя
        /// </summary>
        public string? EncryptUserPassword { get; set; }
        /// <summary>
        /// Сертификат оператора
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Представление
        /// </summary>
        public string DssName { get; set; } = null!;

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoProvider Provider { get; set; } = null!;
        public virtual RoDssTariff RoDssTariff { get; set; } = null!;
        public virtual ICollection<RoDssAuthKey> RoDssAuthKeys { get; set; }
        public virtual ICollection<RoDssAuthSystem> RoDssAuthSystems { get; set; }
        public virtual ICollection<RoDssUserGroup> RoDssUserGroups { get; set; }
        public virtual ICollection<RoDssUser> RoDssUsers { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
    }
}
