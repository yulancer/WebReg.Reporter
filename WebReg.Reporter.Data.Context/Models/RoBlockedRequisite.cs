using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoBlockedRequisite
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int BlockedRequisiteId { get; set; }
        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string? ShortName { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string? Inn { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string? Kpp { get; set; }
        /// <summary>
        /// ОГРН
        /// </summary>
        public string? Ogrn { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronymic { get; set; }
        /// <summary>
        /// СНИЛС
        /// </summary>
        public string? Snils { get; set; }
        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }

        public virtual RoUser? User { get; set; }
    }
}
