using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний для модуля &quot;Потенциальные абоненты&quot;
    /// </summary>
    public partial class RoPotentialAbonentStepType
    {
        public RoPotentialAbonentStepType()
        {
            RoPotentialAbonents = new HashSet<RoPotentialAbonent>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string StepName { get; set; } = null!;
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }

        public virtual RoPotentialAbonentProductType? ProductType { get; set; }
        public virtual ICollection<RoPotentialAbonent> RoPotentialAbonents { get; set; }
    }
}
