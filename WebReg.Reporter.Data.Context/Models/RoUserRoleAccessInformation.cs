using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoUserRoleAccessInformation
    {
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public int? LevelPriority { get; set; }
        public int? AccessLevelId { get; set; }
        public string? AccessLevelName { get; set; }
    }
}
