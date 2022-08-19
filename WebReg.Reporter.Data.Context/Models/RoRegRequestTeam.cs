using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Заявки, одобренные командами
    /// </summary>
    public partial class RoRegRequestTeam
    {
        /// <summary>
        /// Заявка
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Команда
        /// </summary>
        public int OfficeTeamId { get; set; }

        public virtual RoOfficeTeam OfficeTeam { get; set; } = null!;
        public virtual RoRegRequest RegRequest { get; set; } = null!;
    }
}
