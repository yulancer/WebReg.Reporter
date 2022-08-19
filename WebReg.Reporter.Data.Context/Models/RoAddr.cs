using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица адрес (временная)
    /// </summary>
    public partial class RoAddr
    {
        public RoAddr()
        {
            RoAbonentLocationAddresses = new HashSet<RoAbonent>();
            RoAbonentPostalAddresses = new HashSet<RoAbonent>();
            RoOrders = new HashSet<RoOrder>();
            RoPoints = new HashSet<RoPoint>();
            RoProductAbonentLocationAddresses = new HashSet<RoProduct>();
            RoProductAbonentPostalAddresses = new HashSet<RoProduct>();
            RoRegBankRequests = new HashSet<RoRegBankRequest>();
            RoRegRequestLocationAddresses = new HashSet<RoRegRequest>();
            RoRegRequestPostalAddresses = new HashSet<RoRegRequest>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AddrId { get; set; }
        /// <summary>
        /// Индекс
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Район
        /// </summary>
        public string? Area { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string? Locality { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public string? Street { get; set; }
        /// <summary>
        /// Дом
        /// </summary>
        public string? Building { get; set; }
        /// <summary>
        /// Корпус
        /// </summary>
        public string? Bulk { get; set; }
        /// <summary>
        /// Квартира
        /// </summary>
        public string? Flat { get; set; }
        /// <summary>
        /// ФИАС адрес в формате XML
        /// </summary>
        public string? FiasXml { get; set; }
        /// <summary>
        /// Строковое представление ФИАС адреса
        /// </summary>
        public string? FiasStringView { get; set; }
        /// <summary>
        /// Идентификатор ФИАС адреса
        /// </summary>
        public Guid? FiasGuid { get; set; }
        /// <summary>
        /// Адрес, начиная с улицы
        /// </summary>
        public string? StreetAddress { get; set; }

        public virtual RoRegion Region { get; set; } = null!;
        public virtual ICollection<RoAbonent> RoAbonentLocationAddresses { get; set; }
        public virtual ICollection<RoAbonent> RoAbonentPostalAddresses { get; set; }
        public virtual ICollection<RoOrder> RoOrders { get; set; }
        public virtual ICollection<RoPoint> RoPoints { get; set; }
        public virtual ICollection<RoProduct> RoProductAbonentLocationAddresses { get; set; }
        public virtual ICollection<RoProduct> RoProductAbonentPostalAddresses { get; set; }
        public virtual ICollection<RoRegBankRequest> RoRegBankRequests { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequestLocationAddresses { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequestPostalAddresses { get; set; }
    }
}
