using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица документов продуктов
    /// </summary>
    public partial class RoProductDoc
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Абонент
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public int DocId { get; set; }
        /// <summary>
        /// Владелец ключа
        /// </summary>
        public int? ProductPersonId { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public int? KeyId { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int ProductDocId { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoKey? Key { get; set; }
        public virtual RoProductPerson? ProductPerson { get; set; }
        public virtual RoDoc RoDoc { get; set; } = null!;
    }
}
