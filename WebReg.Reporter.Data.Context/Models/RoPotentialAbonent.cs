using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица потенциальных клиентов
    /// </summary>
    public partial class RoPotentialAbonent
    {
        public RoPotentialAbonent()
        {
            RoPotentialAbonentEgais = new HashSet<RoPotentialAbonentEgai>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int PotentialAbonentId { get; set; }
        /// <summary>
        /// Тип абонента
        /// </summary>
        public int AbonentTypeId { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string? Inn { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string? Kpp { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Офиc
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Контакты
        /// </summary>
        public string? Phone { get; set; }
        public string? Email { get; set; }
        /// <summary>
        /// Флаг, указывающий на то, был ли прочитан потенциальный абонент
        /// </summary>
        public bool? IsRead { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int ProductTypeId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// ОГРН
        /// </summary>
        public string? Ogrn { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public string? CityName { get; set; }
        /// <summary>
        /// Количество обособленных предприятий
        /// </summary>
        public int? DetachedUnitsCount { get; set; }

        public virtual RoAbonentType AbonentType { get; set; } = null!;
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoPotentialAbonentStepType Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual RoPotentialAbonentUcb RoPotentialAbonentUcb { get; set; } = null!;
        public virtual ICollection<RoPotentialAbonentEgai> RoPotentialAbonentEgais { get; set; }
    }
}
