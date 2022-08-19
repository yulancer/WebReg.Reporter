using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoDssAuthKey
    {
        public RoDssAuthKey()
        {
            RoDssAuthKeySteps = new HashSet<RoDssAuthKeyStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор ключа
        /// </summary>
        public string IdKey { get; set; } = null!;
        /// <summary>
        /// Срок действия
        /// </summary>
        public DateTime Expired { get; set; }
        /// <summary>
        /// QR-код
        /// </summary>
        public int QrCodeId { get; set; }
        /// <summary>
        /// Пользователь DSS
        /// </summary>
        public int? DssUserId { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int? MemberId { get; set; }
        /// <summary>
        /// DSS
        /// </summary>
        public int DssId { get; set; }

        public virtual RoDss Dss { get; set; } = null!;
        public virtual RoDssUser? DssUser { get; set; }
        public virtual RoRegRequestMember? Member { get; set; }
        public virtual RoFile QrCode { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoDssAuthKeyStep> RoDssAuthKeySteps { get; set; }
    }
}
