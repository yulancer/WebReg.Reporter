using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица групп компаний
    /// </summary>
    public partial class RoCompanyGroup
    {
        public RoCompanyGroup()
        {
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoContracts = new HashSet<RoContract>();
            RoRegRequests = new HashSet<RoRegRequest>();
            Abonents = new HashSet<RoAbonent>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CompanyGroupId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string CompanyGroupName { get; set; } = null!;
        /// <summary>
        /// Главная организация
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int? OfficeId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid CompanyGroupGuid { get; set; }

        public virtual RoAbonent Abonent { get; set; } = null!;
        public virtual RoOffice? Office { get; set; }
        public virtual RoProductType? ProductType { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }

        public virtual ICollection<RoAbonent> Abonents { get; set; }
    }
}
