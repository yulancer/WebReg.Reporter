using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица типов файлов
    /// </summary>
    public partial class RoFileType
    {
        public RoFileType()
        {
            RoFiles = new HashSet<RoFile>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int FileTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string FileTypeName { get; set; } = null!;
        /// <summary>
        /// Расширение
        /// </summary>
        public string FileExtension { get; set; } = null!;

        public virtual ICollection<RoFile> RoFiles { get; set; }
    }
}
