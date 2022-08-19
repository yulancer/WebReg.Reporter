using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoNewsFile
    {
        /// <summary>
        /// Новость
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public int FileId { get; set; }

        public virtual RoNews News { get; set; } = null!;
    }
}
