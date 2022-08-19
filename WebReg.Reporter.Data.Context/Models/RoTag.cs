using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица тегов
    /// </summary>
    public partial class RoTag
    {
        public RoTag()
        {
            News = new HashSet<RoNews>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int TagId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string TagName { get; set; } = null!;
        /// <summary>
        /// Группа
        /// </summary>
        public int? TagGroupId { get; set; }

        public virtual RoTagGroup? TagGroup { get; set; }

        public virtual ICollection<RoNews> News { get; set; }
    }
}
