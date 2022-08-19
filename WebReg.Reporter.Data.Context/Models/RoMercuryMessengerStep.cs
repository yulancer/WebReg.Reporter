using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний курьеров АстралОтчет
    /// </summary>
    public partial class RoMercuryMessengerStep
    {
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// АстралОтчет
        /// </summary>
        public int MercuryId { get; set; }
        /// <summary>
        /// Курьер
        /// </summary>
        public int MessengerId { get; set; }
        /// <summary>
        /// Следующее состояние
        /// </summary>
        public int? NextStepId { get; set; }
        /// <summary>
        /// Ошибка
        /// </summary>
        public string? ErrorMsg { get; set; }
        /// <summary>
        /// Предыдущие состояние
        /// </summary>
        public int? PreviousStepId { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }

        public virtual RoFile? File { get; set; }
        public virtual RoMercuryMessenger Me { get; set; } = null!;
        public virtual RoProduct Mercury { get; set; } = null!;
        public virtual RoMessenger Messenger { get; set; } = null!;
        public virtual RoStep? NextStep { get; set; }
        public virtual RoStep? PreviousStep { get; set; }
        public virtual RoStep Step { get; set; } = null!;
    }
}
