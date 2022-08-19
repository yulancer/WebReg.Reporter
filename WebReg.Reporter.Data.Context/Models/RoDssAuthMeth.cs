using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица методов аутентификации DSS
    /// </summary>
    public partial class RoDssAuthMeth
    {
        public RoDssAuthMeth()
        {
            RoDssAuthSystems = new HashSet<RoDssAuthSystem>();
        }

        /// <summary>
        /// Флаг метода
        /// </summary>
        public int MethId { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Порядок метода
        /// </summary>
        public int? AuthOrder { get; set; }

        public virtual ICollection<RoDssAuthSystem> RoDssAuthSystems { get; set; }
    }
}
