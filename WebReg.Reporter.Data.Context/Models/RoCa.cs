using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица центров сертификации
    /// </summary>
    public partial class RoCa
    {
        public RoCa()
        {
            RoCaAccreditations = new HashSet<RoCaAccreditation>();
            RoCaCertificates = new HashSet<RoCaCertificate>();
            RoCaMessengers = new HashSet<RoCaMessenger>();
            RoCaProductTypes = new HashSet<RoCaProductType>();
            RoCaSettings = new HashSet<RoCaSetting>();
            RoCaTemplates = new HashSet<RoCaTemplate>();
            RoKeys = new HashSet<RoKey>();
            RoMemberReserveKeys = new HashSet<RoMemberReserveKey>();
            RoOffices = new HashSet<RoOffice>();
            RoOperatorIrucs = new HashSet<RoOperatorIruc>();
            RoRas = new HashSet<RoRa>();
            RoRegCertRequests = new HashSet<RoRegCertRequest>();
            RoRegRequestMembers = new HashSet<RoRegRequestMember>();
            RoTariffAttributeCas = new HashSet<RoTariffAttributeCa>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CaName { get; set; } = null!;
        /// <summary>
        /// Cертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Префикс ДУЦ
        /// </summary>
        public string? PrefixDuc { get; set; }
        /// <summary>
        /// Номер сети ViPNet
        /// </summary>
        public string? NetNumber { get; set; }
        /// <summary>
        /// СМ по умолчанию
        /// </summary>
        public string? DefaultCuid { get; set; }
        /// <summary>
        /// Объектный идентификатор политики
        /// </summary>
        public string? PolicyOid { get; set; }
        /// <summary>
        /// Адрес документа политики
        /// </summary>
        public string? PolicyUrl { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Дата отключения
        /// </summary>
        public DateTime? OffTime { get; set; }
        /// <summary>
        /// Системное имя ДУЦ
        /// </summary>
        public string? SystemNameDuc { get; set; }
        /// <summary>
        /// Внешнее имя
        /// </summary>
        public string? CaShortName { get; set; }
        /// <summary>
        /// Квалифицированный
        /// </summary>
        public bool IsQualified { get; set; }
        /// <summary>
        /// Крипто ПРО
        /// </summary>
        public bool IsCryptopro { get; set; }
        /// <summary>
        /// Признак СУЦ(Солидный УЦ)
        /// </summary>
        public bool IsSolid { get; set; }
        /// <summary>
        /// Мнемоника
        /// </summary>
        public string? Mnemonic { get; set; }
        /// <summary>
        /// ИНН УЦ
        /// </summary>
        public string? Inn { get; set; }
        /// <summary>
        /// Издатель
        /// </summary>
        public int? IssuerId { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoVipnetNode? DefaultCu { get; set; }
        public virtual RoIssuer? Issuer { get; set; }
        public virtual RoCaRequestApi RoCaRequestApi { get; set; } = null!;
        public virtual ICollection<RoCaAccreditation> RoCaAccreditations { get; set; }
        public virtual ICollection<RoCaCertificate> RoCaCertificates { get; set; }
        public virtual ICollection<RoCaMessenger> RoCaMessengers { get; set; }
        public virtual ICollection<RoCaProductType> RoCaProductTypes { get; set; }
        public virtual ICollection<RoCaSetting> RoCaSettings { get; set; }
        public virtual ICollection<RoCaTemplate> RoCaTemplates { get; set; }
        public virtual ICollection<RoKey> RoKeys { get; set; }
        public virtual ICollection<RoMemberReserveKey> RoMemberReserveKeys { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
        public virtual ICollection<RoOperatorIruc> RoOperatorIrucs { get; set; }
        public virtual ICollection<RoRa> RoRas { get; set; }
        public virtual ICollection<RoRegCertRequest> RoRegCertRequests { get; set; }
        public virtual ICollection<RoRegRequestMember> RoRegRequestMembers { get; set; }
        public virtual ICollection<RoTariffAttributeCa> RoTariffAttributeCas { get; set; }
    }
}
