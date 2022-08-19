using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица документов
    /// </summary>
    public partial class RoDoc
    {
        public RoDoc()
        {
            RoPersonDocs = new HashSet<RoPersonDoc>();
            RoProductDocs = new HashSet<RoProductDoc>();
            RoRegRequestDocs = new HashSet<RoRegRequestDoc>();
            RegBankRequests = new HashSet<RoRegBankRequest>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int DocId { get; set; }
        /// <summary>
        /// Абонент
        /// </summary>
        public int? AbonentId { get; set; }
        /// <summary>
        /// Вид документа
        /// </summary>
        public int DocTypeId { get; set; }
        /// <summary>
        /// Тип документа удостоверяющего личность
        /// </summary>
        public int? PassportTypeId { get; set; }
        /// <summary>
        /// Серия документа
        /// </summary>
        public string? Series { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        public string? Number { get; set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateOnly? IssueDate { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дополнение
        /// </summary>
        public string? Addon { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Файл
        /// </summary>
        public int? FileId { get; set; }

        public virtual RoAbonent? Abonent { get; set; }
        public virtual RoDocType DocType { get; set; } = null!;
        public virtual RoPassportType? PassportType { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoPersonDoc> RoPersonDocs { get; set; }
        public virtual ICollection<RoProductDoc> RoProductDocs { get; set; }
        public virtual ICollection<RoRegRequestDoc> RoRegRequestDocs { get; set; }

        public virtual ICollection<RoRegBankRequest> RegBankRequests { get; set; }
    }
}
