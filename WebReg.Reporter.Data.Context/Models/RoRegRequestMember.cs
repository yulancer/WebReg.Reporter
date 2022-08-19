using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сотрудников запроса на регистрацию
    /// </summary>
    public partial class RoRegRequestMember
    {
        public RoRegRequestMember()
        {
            RoDssAuthKeys = new HashSet<RoDssAuthKey>();
            RoRegRequestCheckings = new HashSet<RoRegRequestChecking>();
            RoRegRequestDocs = new HashSet<RoRegRequestDoc>();
            RoRegRequestMemberContacts = new HashSet<RoRegRequestMemberContact>();
            RoRegRequestServices = new HashSet<RoRegRequestService>();
            Ekus = new HashSet<RoEku>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// Запрос
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// ГУИД сотрудника
        /// </summary>
        public Guid? MemberGuid { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = null!;
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = null!;
        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronymic { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public int? PassportTypeId { get; set; }
        /// <summary>
        /// Серия документа
        /// </summary>
        public string? PassportSeries { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        public string? PassportNumber { get; set; }
        /// <summary>
        /// Когда выдан документ
        /// </summary>
        public DateOnly? PasportDate { get; set; }
        /// <summary>
        /// Кем выдан документ
        /// </summary>
        public string? PassportAddon { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Подписант
        /// </summary>
        public bool? Signer { get; set; }
        /// <summary>
        /// Шифровальщик
        /// </summary>
        public bool? Encrypt { get; set; }
        /// <summary>
        /// Квалификация подписи
        /// </summary>
        public int SignQualificationId { get; set; }
        /// <summary>
        /// Онлайн
        /// </summary>
        public bool IonOnline { get; set; }
        /// <summary>
        /// Подразделение
        /// </summary>
        public int? OrgUnitId { get; set; }
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int? ProviderId { get; set; }
        /// <summary>
        /// Контейнер
        /// </summary>
        public string? ContainerName { get; set; }
        /// <summary>
        /// Сотрудник продукта
        /// </summary>
        public int? ProductPersonId { get; set; }
        /// <summary>
        /// Ссылка на УЦ
        /// </summary>
        public int? CaId { get; set; }
        /// <summary>
        /// СНИЛС
        /// </summary>
        public string? Snils { get; set; }
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Шаблон сертификата
        /// </summary>
        public int? CertTemplateId { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime? InitialTime { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Тип рег-файла
        /// </summary>
        public int? RegFileTypeId { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public int GenderId { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateOnly? BirthDate { get; set; }
        /// <summary>
        /// Место рождения
        /// </summary>
        public string? BirthPlace { get; set; }
        /// <summary>
        /// Гражданство
        /// </summary>
        public string? CountryId { get; set; }
        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string? SubjectKeyId { get; set; }
        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int? CertId { get; set; }
        /// <summary>
        /// Код подразделения, выдавшего паспорт
        /// </summary>
        public string? PassportUnit { get; set; }
        /// <summary>
        /// Тип хранилища
        /// </summary>
        public int? StorageTypeId { get; set; }
        /// <summary>
        /// Принудительная замена сертификата
        /// </summary>
        public bool ForceUpdate { get; set; }
        /// <summary>
        /// Дата окончания срока действия паспорта
        /// </summary>
        public DateOnly? PassportEndDate { get; set; }
        /// <summary>
        /// Шаблон УЦ
        /// </summary>
        public int? TemplateId { get; set; }
        /// <summary>
        /// Режим аутентификации в DSS
        /// </summary>
        public int? DssAuthModeId { get; set; }
        /// <summary>
        /// Переобновление QR кода
        /// </summary>
        public bool? ForceQrcodeGeneration { get; set; }
        /// <summary>
        /// DSS
        /// </summary>
        public int? DssId { get; set; }
        /// <summary>
        /// Логин DSS
        /// </summary>
        public string? DssLogin { get; set; }
        /// <summary>
        /// ИНН физического лица
        /// </summary>
        public string? Inn { get; set; }
        /// <summary>
        /// Это доверенное лицо
        /// </summary>
        public bool? IsTrusted { get; set; }
        /// <summary>
        /// Сотрудник имеет роль Администратор
        /// </summary>
        public bool? IsAdministrator { get; set; }

        public virtual RoCa? Ca { get; set; }
        public virtual RoCertTemplate? CertTemplate { get; set; }
        public virtual RoCountry? Country { get; set; }
        public virtual RoDss? Dss { get; set; }
        public virtual RoDssAuthMode? DssAuthMode { get; set; }
        public virtual RoGender Gender { get; set; } = null!;
        public virtual RoOrgUnit? OrgUnit { get; set; }
        public virtual RoPassportType? PassportType { get; set; }
        public virtual RoPost? Post { get; set; }
        public virtual RoProductPerson? ProductPerson { get; set; }
        public virtual RoProvider? Provider { get; set; }
        public virtual RoRegFileType? RegFileType { get; set; }
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoSignQualification SignQualification { get; set; } = null!;
        public virtual RoStorageType? StorageType { get; set; }
        public virtual RoCaTemplate? Template { get; set; }
        public virtual RoMemberReserveKey RoMemberReserveKey { get; set; } = null!;
        public virtual ICollection<RoDssAuthKey> RoDssAuthKeys { get; set; }
        public virtual ICollection<RoRegRequestChecking> RoRegRequestCheckings { get; set; }
        public virtual ICollection<RoRegRequestDoc> RoRegRequestDocs { get; set; }
        public virtual ICollection<RoRegRequestMemberContact> RoRegRequestMemberContacts { get; set; }
        public virtual ICollection<RoRegRequestService> RoRegRequestServices { get; set; }

        public virtual ICollection<RoEku> Ekus { get; set; }
    }
}
