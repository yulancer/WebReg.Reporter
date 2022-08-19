using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица резервных ключей сотрудников
    /// </summary>
    public partial class RoMemberReserveKey
    {
        /// <summary>
        /// Сотрудник
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// Криптопровайдер
        /// </summary>
        public int? ProviderId { get; set; }
        /// <summary>
        /// Контейнер
        /// </summary>
        public string? ContainerName { get; set; }
        /// <summary>
        /// Ссылка на УЦ
        /// </summary>
        public int? CaId { get; set; }
        /// <summary>
        /// Идентификатор ключа субъекта
        /// </summary>
        public string? SubjectKeyId { get; set; }
        /// <summary>
        /// Запрос на сертификат
        /// </summary>
        public int? CertRequestId { get; set; }

        public virtual RoCa? Ca { get; set; }
        public virtual RoFile? CertRequest { get; set; }
        public virtual RoRegRequestMember Member { get; set; } = null!;
        public virtual RoProvider? Provider { get; set; }
    }
}
