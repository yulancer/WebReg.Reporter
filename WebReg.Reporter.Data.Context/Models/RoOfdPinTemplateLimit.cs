using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ограничений использования шаблона
    /// </summary>
    public partial class RoOfdPinTemplateLimit
    {
        /// <summary>
        /// Ид. шаблона
        /// </summary>
        public Guid OfdPinTemplateId { get; set; }
        /// <summary>
        /// Ограничение
        /// </summary>
        public int LimitId { get; set; }
        /// <summary>
        /// Целочисленное значение
        /// </summary>
        public int? LimitValueInt { get; set; }

        public virtual RoLimit Limit { get; set; } = null!;
        public virtual RoOfdPinTemplate OfdPinTemplate { get; set; } = null!;
    }
}
