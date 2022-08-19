using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Участники команды
    /// </summary>
    public partial class RoOfficeTeamPerson
    {
        /// <summary>
        /// Идентификатор участника
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Команда
        /// </summary>
        public int OfficeTeamId { get; set; }
        /// <summary>
        /// Фамилия участника
        /// </summary>
        public string? PersonName { get; set; }

        public virtual RoOfficeTeam OfficeTeam { get; set; } = null!;
    }
}
