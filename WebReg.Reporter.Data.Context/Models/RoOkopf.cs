using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ОКОПФ
    /// </summary>
    public partial class RoOkopf
    {
        public RoOkopf()
        {
            RoAbonents = new HashSet<RoAbonent>();
            RoRegRequests = new HashSet<RoRegRequest>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int OkopfId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string OkopfName { get; set; } = null!;
        public string? OkopfShortName { get; set; }
        /// <summary>
        /// Код ОК 028-99
        /// </summary>
        public string? Code99 { get; set; }
        /// <summary>
        /// Код ОК 028-2012
        /// </summary>
        public string Code2012 { get; set; } = null!;
        /// <summary>
        /// Бюджетное учреждение
        /// </summary>
        public bool Budget { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoAbonent> RoAbonents { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
    }
}
