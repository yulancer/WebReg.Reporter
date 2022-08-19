using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Ежемесячные сверки между партнером и Центром продаж
    /// </summary>
    public partial class RoAgentBalance
    {
        public RoAgentBalance()
        {
            RoAgentBalanceBills = new HashSet<RoAgentBalanceBill>();
            RoAgentBalanceDetails = new HashSet<RoAgentBalanceDetail>();
            RoAgentBalanceOffices = new HashSet<RoAgentBalanceOffice>();
        }

        /// <summary>
        /// Идентификатор сверки
        /// </summary>
        public int BalanceId { get; set; }
        /// <summary>
        /// Год сверки
        /// </summary>
        public int BalanceYear { get; set; }
        /// <summary>
        /// Месяц сверки
        /// </summary>
        public int BalanceMonth { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Дата, когда сверка стала не одобреной
        /// </summary>
        public DateTime LastUnacceptDate { get; set; }
        /// <summary>
        /// Дата одобрения сверки партнером
        /// </summary>
        public DateTime? PartnerAcceptDate { get; set; }
        /// <summary>
        /// Дата одобрения сверки Центром продаж
        /// </summary>
        public DateTime? SaleCenterAcceptDate { get; set; }
        /// <summary>
        /// Процент вознаграждения
        /// </summary>
        public decimal PercentReward { get; set; }
        /// <summary>
        /// Дата одобрения сверки АО
        /// </summary>
        public DateTime? MercuryAcceptDate { get; set; }
        /// <summary>
        /// % вознаграждения агента Астрал-отчёт
        /// </summary>
        public decimal? MercuryAgentPercentReward { get; set; }
        /// <summary>
        /// % вознаграждения ЦП Астрал-отчёт
        /// </summary>
        public decimal? MercuryScPercentReward { get; set; }
        /// <summary>
        /// Дата одобрения сверки ЭТП партнёром
        /// </summary>
        public DateTime? EtpAcceptDate { get; set; }
        /// <summary>
        /// Дата одобрения сверки ЭТП ЦП
        /// </summary>
        public DateTime? EtpScAcceptDate { get; set; }
        /// <summary>
        /// Дата одобрения вендором
        /// </summary>
        public DateTime? EtpVendorAcceptDate { get; set; }
        /// <summary>
        /// ЦП
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// % вознаграждения агента ЭТП
        /// </summary>
        public decimal? EtpAgentPercentReward { get; set; }
        /// <summary>
        /// Дата одобрения счетов 1СО
        /// </summary>
        public DateTime? BillAcceptDate { get; set; }
        /// <summary>
        /// Дата одобрения счета ОФД
        /// </summary>
        public DateTime? OfdBillAcceptDate { get; set; }
        /// <summary>
        /// Дата одобрения счета ЭТП(Астрал-ЭТ)
        /// </summary>
        public DateTime? EtpBillAcceptDate { get; set; }
        /// <summary>
        /// % вознаграждения агента АО5
        /// </summary>
        public decimal? Ao5AgentPercentReward { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceBill> RoAgentBalanceBills { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetails { get; set; }
        public virtual ICollection<RoAgentBalanceOffice> RoAgentBalanceOffices { get; set; }
    }
}
