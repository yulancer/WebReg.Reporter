using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoBillDocumentType
    {
        public RoBillDocumentType()
        {
            RoBillDocuments = new HashSet<RoBillDocument>();
        }

        public int DocumentTypeId { get; set; }
        public string? DocumentTypeName { get; set; }

        public virtual ICollection<RoBillDocument> RoBillDocuments { get; set; }
    }
}
