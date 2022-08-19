using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// API для запросов на сертификат
    /// </summary>
    public partial class RoCaRequestApi
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaRequestApiId { get; set; }
        /// <summary>
        /// УЦ
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// неактивен (not null)
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Идентификатор УЦ во внешней системе
        /// </summary>
        public Guid ExternalCaGuid { get; set; }
        /// <summary>
        /// Url для отправки запроса на сертификат
        /// </summary>
        public string EntrypointUrl { get; set; } = null!;
        /// <summary>
        /// Url отправки ответа (сертификата) от внешней системы
        /// </summary>
        public string CallbackUrl { get; set; } = null!;

        public virtual RoCa Ca { get; set; } = null!;
    }
}
