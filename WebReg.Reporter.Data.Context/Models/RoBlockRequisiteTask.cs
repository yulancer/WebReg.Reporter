using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoBlockRequisiteTask
    {
        public int BlockRequisiteTaskId { get; set; }
        public string InnListJson { get; set; } = null!;
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string? Message { get; set; }
        public int UserId { get; set; }

        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
