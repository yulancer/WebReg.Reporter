using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сокращений типов объектов адреса
    /// </summary>
    public partial class RoSocrbase
    {
        /// <summary>
        /// Уровень
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// Сокращение
        /// </summary>
        public string Scname { get; set; } = null!;
        /// <summary>
        /// Наименование
        /// </summary>
        public string? Socrname { get; set; }
        /// <summary>
        /// Код
        /// </summary>
        public int? KodTSt { get; set; }
    }
}
