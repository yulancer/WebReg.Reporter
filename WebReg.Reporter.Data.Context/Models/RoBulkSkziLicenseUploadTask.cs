using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoBulkSkziLicenseUploadTask
    {
        public int BulkSkziLicenseUploadTaskId { get; set; }
        public int? LicenseListFileId { get; set; }
        public int? LicensesPdfFileId { get; set; }
        public DateTime CreationTime { get; set; }
        public int StepId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string? Message { get; set; }
        public int UserId { get; set; }
        public int MerchandiseId { get; set; }

        public virtual RoFile? LicenseListFile { get; set; }
        public virtual RoFile? LicensesPdfFile { get; set; }
        public virtual RoMerchandise Merchandise { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
    }
}
