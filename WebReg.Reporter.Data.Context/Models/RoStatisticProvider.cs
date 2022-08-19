﻿using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица статистики поставщиков
    /// </summary>
    public partial class RoStatisticProvider
    {
        /// <summary>
        /// Идентификатор поставщика
        /// </summary>
        public int StatisticProviderId { get; set; }
        public int? AbonentId { get; set; }
        /// <summary>
        /// Наименование победителя
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Эл. почта
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string? ContactPerson { get; set; }
        /// <summary>
        /// Максимальная сумма
        /// </summary>
        public decimal? MaxSum { get; set; }
        /// <summary>
        /// Сумма по столбцу Количество аукционов
        /// </summary>
        public int SumCountAuctions { get; set; }
        /// <summary>
        /// Сумма по столбцу Количество побед
        /// </summary>
        public int SumCountWin { get; set; }
        /// <summary>
        /// Сумма по столбцу Количество контрактов
        /// </summary>
        public int SumCountContract { get; set; }

        public virtual RoAbonent? Abonent { get; set; }
    }
}
