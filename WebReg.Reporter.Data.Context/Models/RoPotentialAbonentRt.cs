using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица с даными о победителях РТС
    /// </summary>
    public partial class RoPotentialAbonentRt
    {
        /// <summary>
        /// Номер закупки
        /// </summary>
        public string PurchaseNumber { get; set; } = null!;
        /// <summary>
        /// Идентификатор потенциального клиента
        /// </summary>
        public int PotentialAbonentId { get; set; }
        /// <summary>
        /// Сумма сделки
        /// </summary>
        public decimal DealSum { get; set; }
        /// <summary>
        /// Тип закупки
        /// </summary>
        public int PurchaseTypeId { get; set; }
        /// <summary>
        /// Дата протокола о подведении итогов
        /// </summary>
        public DateOnly? ProtocolDate { get; set; }
        /// <summary>
        /// Площадка
        /// </summary>
        public string? PlaceName { get; set; }
        /// <summary>
        /// Адрес площадки
        /// </summary>
        public string? PlaceAddress { get; set; }
        /// <summary>
        /// Начало срока действия банковской гарантии
        /// </summary>
        public DateOnly GuarantyBeginDate { get; set; }
        /// <summary>
        /// Конец срока действия банковской гарантии
        /// </summary>
        public DateOnly GuarantyEndDate { get; set; }
        /// <summary>
        /// Вознаграждение
        /// </summary>
        public decimal DealReward { get; set; }

        public virtual RoPurchaseType PurchaseType { get; set; } = null!;
    }
}
