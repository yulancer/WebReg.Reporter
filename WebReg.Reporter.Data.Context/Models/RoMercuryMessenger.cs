using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица курьеров АстралОтчет
    /// </summary>
    public partial class RoMercuryMessenger
    {
        public RoMercuryMessenger()
        {
            RoMercuryMessengerSteps = new HashSet<RoMercuryMessengerStep>();
            RoMercuryRecipients = new HashSet<RoMercuryRecipient>();
        }

        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Логин входящий
        /// </summary>
        public string? AccountIn { get; set; }
        /// <summary>
        /// Логин исходящий
        /// </summary>
        public string? AccountOut { get; set; }
        /// <summary>
        /// Пароль входящий
        /// </summary>
        public string? PasswordIn { get; set; }
        /// <summary>
        /// Пароль исходящий
        /// </summary>
        public string? PasswordOut { get; set; }
        /// <summary>
        /// Идентификатор пакета
        /// </summary>
        public string? PackId { get; set; }
        /// <summary>
        /// Состояния
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Логин в ИРУЦ
        /// </summary>
        public string? IrucAccount { get; set; }
        /// <summary>
        /// Пароль в ИРУЦ
        /// </summary>
        public string? IrucPassword { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Дата оключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Оператор ИРУЦ
        /// </summary>
        public int? OperatorIrucId { get; set; }

        public virtual RoProduct Mercury { get; set; } = null!;
        public virtual RoMessenger Messenger { get; set; } = null!;
        public virtual RoOperatorIruc? OperatorIruc { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerSteps { get; set; }
        public virtual ICollection<RoMercuryRecipient> RoMercuryRecipients { get; set; }
    }
}
