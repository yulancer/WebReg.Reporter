using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Типы цен и налогов
    /// </summary>
    public partial class RoCoefficientType
    {
        /// <summary>
        /// Тип коэффициента
        /// </summary>
        public int CoefficientTypeId { get; set; }
        /// <summary>
        /// Имя типа
        /// </summary>
        public string? CoefficientTypeName { get; set; }
    }
}
