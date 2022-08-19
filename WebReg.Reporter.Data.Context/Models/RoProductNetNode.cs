using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица сетевых узло продуктов
    /// </summary>
    public partial class RoProductNetNode
    {
        public RoProductNetNode()
        {
            RoProductNetNodeSteps = new HashSet<RoProductNetNodeStep>();
        }

        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Сетевой узел
        /// </summary>
        public string NetNodeName { get; set; } = null!;
        /// <summary>
        /// Шлюз Астрал Онлайн
        /// </summary>
        public Guid GateGuid { get; set; }
        public int StepId { get; set; }

        public virtual RoGate GateGu { get; set; } = null!;
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoProductNetNodeStep> RoProductNetNodeSteps { get; set; }
    }
}
