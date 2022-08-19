using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Издатели
    /// </summary>
    public partial class RoIssuer
    {
        public RoIssuer()
        {
            RoCas = new HashSet<RoCa>();
            RoIssuerAccreditations = new HashSet<RoIssuerAccreditation>();
        }

        /// <summary>
        /// ИД издателя
        /// </summary>
        public int IssuerId { get; set; }
        /// <summary>
        /// Наименование издателя
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// ИНН издателя
        /// </summary>
        public string Inn { get; set; } = null!;

        public virtual ICollection<RoCa> RoCas { get; set; }
        public virtual ICollection<RoIssuerAccreditation> RoIssuerAccreditations { get; set; }
    }
}
