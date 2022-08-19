using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Возвращает выборку всех сертов по продуктам
    /// </summary>
    public partial class RoCertificateInProduct
    {
        public int? CertificateId { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ProductId { get; set; }
        public int? ProductTypeId { get; set; }
    }
}
