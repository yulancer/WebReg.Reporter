using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний аутентификации пользователей DSS
    /// </summary>
    public partial class RoDssAuth
    {
        public RoDssAuth()
        {
            RoDssAuthSteps = new HashSet<RoDssAuthStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AuthId { get; set; }
        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Шаг аутентификации
        /// </summary>
        public int StepId { get; set; }
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Время проверки
        /// </summary>
        public DateTime? CheckTime { get; set; }
        /// <summary>
        /// QR-код
        /// </summary>
        public int? QrCodeId { get; set; }
        /// <summary>
        /// Серийный номер
        /// </summary>
        public string? Serial { get; set; }
        /// <summary>
        /// Владелец ЭП
        /// </summary>
        public int? ProductPersonId { get; set; }
        /// <summary>
        /// Система аутентификации
        /// </summary>
        public int AuthSystemId { get; set; }

        public virtual RoDssAuthSystem AuthSystem { get; set; } = null!;
        public virtual RoProductPerson? ProductPerson { get; set; }
        public virtual RoFile? QrCode { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoDssUser User { get; set; } = null!;
        public virtual ICollection<RoDssAuthStep> RoDssAuthSteps { get; set; }
    }
}
