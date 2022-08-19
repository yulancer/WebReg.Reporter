using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица документов заявлений
    /// </summary>
    public partial class RoRegRequestDoc
    {
        /// <summary>
        /// Заявление
        /// </summary>
        public int RegRequestId { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public int DocId { get; set; }
        /// <summary>
        /// Источник документа: 1 - заявление, 2 - продукт
        /// </summary>
        public int? SourceId { get; set; }
        /// <summary>
        /// ИД сотрудника
        /// </summary>
        public int? MemberId { get; set; }

        public virtual RoDoc Doc { get; set; } = null!;
        public virtual RoRegRequestMember? Member { get; set; }
        public virtual RoRegRequest RegRequest { get; set; } = null!;
    }
}
