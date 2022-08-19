using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoPotentialAbonentContactCatalog
    {
        /// <summary>
        /// Наименование абонента
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// инн
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// кпп
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// дополнительный e-mail
        /// </summary>
        public string? Email2 { get; set; }
        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string? ContactPerson { get; set; }
    }
}
