using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Выставленные счета
    /// </summary>
    public partial class RoSendedBill
    {
        public RoSendedBill()
        {
            RoAgentBalanceBills = new HashSet<RoAgentBalanceBill>();
            RoBillDocuments = new HashSet<RoBillDocument>();
            RoMerchandiseBills = new HashSet<RoMerchandiseBill>();
            RoOfdPins = new HashSet<RoOfdPin>();
            RoOrders = new HashSet<RoOrder>();
            RoSkziLicenses = new HashSet<RoSkziLicense>();
        }

        /// <summary>
        /// Агент который выставляет счет
        /// </summary>
        public int? AgentFromId { get; set; }
        /// <summary>
        /// Агент которому выставляется счет
        /// </summary>
        public int? AgentToId { get; set; }
        /// <summary>
        /// Дата создания заявки на счет
        /// </summary>
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// Номер счета
        /// </summary>
        public string? BillNumber { get; set; }
        /// <summary>
        /// Оплачено или нет
        /// </summary>
        public bool? PaidFor { get; set; }
        /// <summary>
        /// Ид счета
        /// </summary>
        public int BillId { get; set; }
        public Guid? BillGuid { get; set; }
        /// <summary>
        /// Дата счета
        /// </summary>
        public DateTime? BillDate { get; set; }
        /// <summary>
        /// Полная сумма счета (включая НДС)
        /// </summary>
        public decimal? BillTotalSum { get; set; }
        /// <summary>
        /// Сумма НДС
        /// </summary>
        public decimal? BillNdsSum { get; set; }
        public int? AbonentId { get; set; }
        public decimal BillPayedSum { get; set; }
        public bool IsSent { get; set; }
        public int? InvoiceReturnTypeId { get; set; }
        /// <summary>
        /// Дата аннулирования счета
        /// </summary>
        public DateTime? CancelTime { get; set; }
        /// <summary>
        /// Дата блокировки
        /// </summary>
        public DateTime? BlockTime { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Notice { get; set; }
        /// <summary>
        /// Счет
        /// </summary>
        public int? DocumentId { get; set; }
        /// <summary>
        /// Ид. кошелька
        /// </summary>
        public Guid? WalletGuid { get; set; }

        public virtual RoAbonent? Abonent { get; set; }
        public virtual RoAgent? AgentFrom { get; set; }
        public virtual RoAgent? AgentTo { get; set; }
        public virtual RoInvoiceReturnType? InvoiceReturnType { get; set; }
        public virtual ICollection<RoAgentBalanceBill> RoAgentBalanceBills { get; set; }
        public virtual ICollection<RoBillDocument> RoBillDocuments { get; set; }
        public virtual ICollection<RoMerchandiseBill> RoMerchandiseBills { get; set; }
        public virtual ICollection<RoOfdPin> RoOfdPins { get; set; }
        public virtual ICollection<RoOrder> RoOrders { get; set; }
        public virtual ICollection<RoSkziLicense> RoSkziLicenses { get; set; }
    }
}
