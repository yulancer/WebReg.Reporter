using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoAstralWorkflowClient
    {
        public Guid WorkflowGuid { get; set; }
        public int? AbonentId { get; set; }
        public DateOnly? CreateDate { get; set; }
        public int? LastRegRequestId { get; set; }
        public int? CertificateId { get; set; }
        public Guid? GateGuid { get; set; }

        public virtual RoAbonent? Abonent { get; set; }
        public virtual RoCertificate? Certificate { get; set; }
        public virtual RoRegRequest? LastRegRequest { get; set; }
    }
}
