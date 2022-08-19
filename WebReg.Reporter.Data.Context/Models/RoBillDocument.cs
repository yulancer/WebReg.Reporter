using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoBillDocument
    {
        public int BillDocumentId { get; set; }
        public int? BillId { get; set; }
        public int DocumentTypeId { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        /// <summary>
        /// Сумма платежа
        /// </summary>
        public decimal? PaidSum { get; set; }
        /// <summary>
        /// Идентификатор платежа
        /// </summary>
        public Guid? PaymentGuid { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public int? DocumentId { get; set; }

        public virtual RoSendedBill? Bill { get; set; }
        public virtual RoBillDocumentType DocumentType { get; set; } = null!;
    }
}
