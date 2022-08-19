using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица доверенностей пользователей
    /// </summary>
    public partial class RoUserTrust
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int UserTrustId { get; set; }
        public int UserId { get; set; }
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
        /// Серия паспорта
        /// </summary>
        public string PassportSeries { get; set; } = null!;
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string PassportNumber { get; set; } = null!;
        /// <summary>
        /// Кем выдан паспорт
        /// </summary>
        public string PassportAddon { get; set; } = null!;
        /// <summary>
        /// Когда выдан паспорт
        /// </summary>
        public DateOnly PassportDate { get; set; }
        /// <summary>
        /// Дата начала доверенности
        /// </summary>
        public DateOnly InitialDate { get; set; }
        /// <summary>
        /// Дата окончания доверенности
        /// </summary>
        public DateOnly EndDate { get; set; }
        /// <summary>
        /// Дата отключения доверенности
        /// </summary>
        public DateTime? OffTime { get; set; }
        public int? FileId { get; set; }

        public virtual RoFile? File { get; set; }
        public virtual RoUser User { get; set; } = null!;
    }
}
