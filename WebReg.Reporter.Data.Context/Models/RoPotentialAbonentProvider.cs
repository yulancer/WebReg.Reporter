using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица для поставщиков
    /// </summary>
    public partial class RoPotentialAbonentProvider
    {
        /// <summary>
        /// Идентификатор лида
        /// </summary>
        public int PotentialAbonentId { get; set; }
        /// <summary>
        /// Максимальная сумма аукциона
        /// </summary>
        public decimal MaxSum { get; set; }
        /// <summary>
        /// Общее количество участий
        /// </summary>
        public int SumCountAuctions { get; set; }
        /// <summary>
        /// Общее количество побед
        /// </summary>
        public int SumCountWin { get; set; }
        /// <summary>
        /// Общее количество контрагентов
        /// </summary>
        public int SumCountContract { get; set; }
    }
}
