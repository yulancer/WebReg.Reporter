using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица файлов
    /// </summary>
    public partial class RoFile
    {
        public RoFile()
        {
            RoBulkSkziLicenseUploadTaskLicenseListFiles = new HashSet<RoBulkSkziLicenseUploadTask>();
            RoBulkSkziLicenseUploadTaskLicensesPdfFiles = new HashSet<RoBulkSkziLicenseUploadTask>();
            RoCertificates = new HashSet<RoCertificate>();
            RoDssAuthKeys = new HashSet<RoDssAuthKey>();
            RoDssAuths = new HashSet<RoDssAuth>();
            RoDssUsers = new HashSet<RoDssUser>();
            RoKeys = new HashSet<RoKey>();
            RoMemberReserveKeys = new HashSet<RoMemberReserveKey>();
            RoMercuryMessengerSteps = new HashSet<RoMercuryMessengerStep>();
            RoProductCheckings = new HashSet<RoProductChecking>();
            RoRegRequestCheckings = new HashSet<RoRegRequestChecking>();
            RoSkziLicenses = new HashSet<RoSkziLicense>();
            RoSmevRequestStages = new HashSet<RoSmevRequestStage>();
            RoUserTrusts = new HashSet<RoUserTrust>();
            RequestComments = new HashSet<RoAgentBalanceDetailChangeRequestComment>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// Тип файла
        /// </summary>
        public int FileTypeId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Данные
        /// </summary>
        public byte[]? Data { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Гуид
        /// </summary>
        public Guid FileGuid { get; set; }
        /// <summary>
        /// Время удаления
        /// </summary>
        public DateTime? CleaningTime { get; set; }

        public virtual RoFileType FileType { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual ICollection<RoBulkSkziLicenseUploadTask> RoBulkSkziLicenseUploadTaskLicenseListFiles { get; set; }
        public virtual ICollection<RoBulkSkziLicenseUploadTask> RoBulkSkziLicenseUploadTaskLicensesPdfFiles { get; set; }
        public virtual ICollection<RoCertificate> RoCertificates { get; set; }
        public virtual ICollection<RoDssAuthKey> RoDssAuthKeys { get; set; }
        public virtual ICollection<RoDssAuth> RoDssAuths { get; set; }
        public virtual ICollection<RoDssUser> RoDssUsers { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoMemberReserveKey> RoMemberReserveKeys { get; set; }
        public virtual ICollection<RoMercuryMessengerStep> RoMercuryMessengerSteps { get; set; }
        public virtual ICollection<RoProductChecking> RoProductCheckings { get; set; }
        public virtual ICollection<RoRegRequestChecking> RoRegRequestCheckings { get; set; }
        public virtual ICollection<RoSkziLicense> RoSkziLicenses { get; set; }
        public virtual ICollection<RoSmevRequestStage> RoSmevRequestStages { get; set; }
        public virtual ICollection<RoUserTrust> RoUserTrusts { get; set; }

        public virtual ICollection<RoAgentBalanceDetailChangeRequestComment> RequestComments { get; set; }
    }
}
