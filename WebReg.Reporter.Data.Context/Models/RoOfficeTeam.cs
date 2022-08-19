using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Команды
    /// </summary>
    public partial class RoOfficeTeam
    {
        public RoOfficeTeam()
        {
            RoOfficeTeamPeople = new HashSet<RoOfficeTeamPerson>();
            RoRegRequestTeams = new HashSet<RoRegRequestTeam>();
        }

        /// <summary>
        /// Идентификатор команды
        /// </summary>
        public int OfficeTeamId { get; set; }
        /// <summary>
        /// Офис команды
        /// </summary>
        public int? OfficeId { get; set; }

        public virtual RoOffice? Office { get; set; }
        public virtual ICollection<RoOfficeTeamPerson> RoOfficeTeamPeople { get; set; }
        public virtual ICollection<RoRegRequestTeam> RoRegRequestTeams { get; set; }
    }
}
