using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сотрудников
    /// </summary>
    public partial class RoAbonentPerson
    {
        public RoAbonentPerson()
        {
            RoProductPeople = new HashSet<RoProductPerson>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AbonentPersonId { get; set; }
        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Личность
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Подразделение
        /// </summary>
        public int? OrgUnitId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        public string? PostName { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public string? Document { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        public string? DocumentNumber { get; set; }
        /// <summary>
        /// Дата документа
        /// </summary>
        public DateOnly? DocumentDate { get; set; }
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string? Email { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoOrgUnit? OrgUnit { get; set; }
        public virtual RoPerson Person { get; set; } = null!;
        public virtual RoPost? Post { get; set; }
        public virtual ICollection<RoProductPerson> RoProductPeople { get; set; }
    }
}
