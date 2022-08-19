using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoNewsLastVisit
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Дата последнего посещения вкладки новостей
        /// </summary>
        public DateTime LastVisitDate { get; set; }
    }
}
