using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Сведения о ценах и налогах
    /// </summary>
    public partial class RoCoefficient
    {
        public int CoefficientId { get; set; }
        /// <summary>
        /// Тип коэффициента (цена, налог)
        /// </summary>
        public int? CoefficientTypeId { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public double? Value { get; set; }
        /// <summary>
        /// Ид номенклатуры
        /// </summary>
        public int? MerchandiseId { get; set; }
    }
}
