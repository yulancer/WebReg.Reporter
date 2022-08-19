using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов стадий взаимодействия со СМЭВ
    /// </summary>
    public partial class RoSmevStageType
    {
        public RoSmevStageType()
        {
            RoSmevRequestStages = new HashSet<RoSmevRequestStage>();
        }

        /// <summary>
        /// Идентификатор типа
        /// </summary>
        public int StageTypeId { get; set; }
        /// <summary>
        /// Название стадии
        /// </summary>
        public string? StageName { get; set; }

        public virtual ICollection<RoSmevRequestStage> RoSmevRequestStages { get; set; }
    }
}
