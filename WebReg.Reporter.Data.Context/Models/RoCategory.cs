using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица категорий абонентов
    /// </summary>
    public partial class RoCategory
    {
        public RoCategory()
        {
            RoProducts = new HashSet<RoProduct>();
            RoRegRequests = new HashSet<RoRegRequest>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<RoProduct> RoProducts { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
    }
}
