using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица для описания доп. услуг, указанных в заявке.
    /// </summary>
    public partial class RoRegRequestService
    {
        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public int ServiceId { get; set; }
        /// <summary>
        /// Ссылка на заявку
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Ссылка на тип услуги
        /// </summary>
        public int ServiceTypeId { get; set; }
        /// <summary>
        /// Номер услуги
        /// </summary>
        public string? ServiceNumber { get; set; }
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int? MemberId { get; set; }

        public virtual RoRegRequestMember? Member { get; set; }
        public virtual RoRegRequest RegRequest { get; set; } = null!;
        public virtual RoServiceType ServiceType { get; set; } = null!;
        public virtual RoUser? User { get; set; }
    }
}
