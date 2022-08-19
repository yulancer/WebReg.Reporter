using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Описание операций логирования
    /// </summary>
    public partial class RoLogExtendedOperationDesc
    {
        public RoLogExtendedOperationDesc()
        {
            RoLogExtendeds = new HashSet<RoLogExtended>();
        }

        public int OperationId { get; set; }
        public string OperationDescription { get; set; } = null!;

        public virtual ICollection<RoLogExtended> RoLogExtendeds { get; set; }
    }
}
