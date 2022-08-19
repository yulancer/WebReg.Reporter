using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoWorkCalendar
    {
        /// <summary>
        /// Рабочий день
        /// </summary>
        public DateOnly WorkDay { get; set; }
        /// <summary>
        /// Признак праздничного дня
        /// </summary>
        public bool IsHoliday { get; set; }
    }
}
