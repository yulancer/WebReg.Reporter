using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица физических лиц
    /// </summary>
    public partial class RoPerson
    {
        public RoPerson()
        {
            RoAbonentPeople = new HashSet<RoAbonentPerson>();
            RoKeys = new HashSet<RoKey>();
            RoPersonDocs = new HashSet<RoPersonDoc>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PersonId { get; set; }
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
        /// Псевдоним
        /// </summary>
        public string? Pseudonym { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public int PassportTypeId { get; set; }
        /// <summary>
        /// Серия документа
        /// </summary>
        public string PassportSeries { get; set; } = null!;
        /// <summary>
        /// Номер документа
        /// </summary>
        public string PassportNumber { get; set; } = null!;
        /// <summary>
        /// Кем выдан документ
        /// </summary>
        public string? PassportAddon { get; set; }
        /// <summary>
        /// Мобильный
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Домашний телефон
        /// </summary>
        public string? HomePhone { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateOnly? BirthDate { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Когда выдан документ
        /// </summary>
        public DateOnly? PasportDate { get; set; }
        /// <summary>
        /// СНИЛС
        /// </summary>
        public string? Snils { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public int GenderId { get; set; }
        /// <summary>
        /// Место рождения
        /// </summary>
        public string? BirthPlace { get; set; }
        /// <summary>
        /// Гражданство
        /// </summary>
        public string? CountryId { get; set; }
        /// <summary>
        /// Код подразделения, выдавшего паспорт
        /// </summary>
        public string? PassportUnit { get; set; }
        /// <summary>
        /// Дата окончания срока действия паспорта
        /// </summary>
        public DateOnly? PassportEndDate { get; set; }
        /// <summary>
        /// ИНН физического лица
        /// </summary>
        public string? Inn { get; set; }

        public virtual RoCountry? Country { get; set; }
        public virtual RoGender Gender { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoPassportType PassportType { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoAbonentPerson> RoAbonentPeople { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoPersonDoc> RoPersonDocs { get; set; }
    }
}
