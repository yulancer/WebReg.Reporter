using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Система аутентификации DSS
    /// </summary>
    public partial class RoDssAuthSystem
    {
        public RoDssAuthSystem()
        {
            RoDssAuths = new HashSet<RoDssAuth>();
        }

        /// <summary>
        /// Идентификатор системы
        /// </summary>
        public int AuthSystemId { get; set; }
        /// <summary>
        /// Метод аутентификации
        /// </summary>
        public int MethId { get; set; }
        /// <summary>
        /// Псевдоним системы
        /// </summary>
        public string SystemAlias { get; set; } = null!;
        /// <summary>
        /// Идентификатор системы в DSS
        /// </summary>
        public string? SystemId { get; set; }
        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }
        /// <summary>
        /// Используется по умолчанию
        /// </summary>
        public bool IsDefault { get; set; }

        public virtual RoDss Dss { get; set; } = null!;
        public virtual RoDssAuthMeth Meth { get; set; } = null!;
        public virtual ICollection<RoDssAuth> RoDssAuths { get; set; }
    }
}
