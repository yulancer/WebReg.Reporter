using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица объектов адреса
    /// </summary>
    public partial class RoAddressObject
    {
        public RoAddressObject()
        {
            InverseParent = new HashSet<RoAddressObject>();
            RoAddressAreas = new HashSet<RoAddress>();
            RoAddressCities = new HashSet<RoAddress>();
            RoAddressLocalities = new HashSet<RoAddress>();
            RoAddressRegions = new HashSet<RoAddress>();
            RoAddressStreets = new HashSet<RoAddress>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AddressObjectId { get; set; }
        /// <summary>
        /// Родитель
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Префикс
        /// </summary>
        public int PrefixId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string AddressObjectName { get; set; } = null!;
        /// <summary>
        /// Код
        /// </summary>
        public string AddressObjectCode { get; set; } = null!;
        public string? PostalCode { get; set; }
        /// <summary>
        /// Код ИФНС
        /// </summary>
        public string? TaxCode { get; set; }
        /// <summary>
        /// Код тер. уч. ИФНС
        /// </summary>
        public string? AreaTaxCode { get; set; }
        /// <summary>
        /// ОКАТО
        /// </summary>
        public string? Okato { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public int? Status { get; set; }

        public virtual RoAddressObject? Parent { get; set; }
        public virtual RoAddressObjectPrefix Prefix { get; set; } = null!;
        public virtual ICollection<RoAddressObject> InverseParent { get; set; }
        public virtual ICollection<RoAddress> RoAddressAreas { get; set; }
        public virtual ICollection<RoAddress> RoAddressCities { get; set; }
        public virtual ICollection<RoAddress> RoAddressLocalities { get; set; }
        public virtual ICollection<RoAddress> RoAddressRegions { get; set; }
        public virtual ICollection<RoAddress> RoAddressStreets { get; set; }
    }
}
