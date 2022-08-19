using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Заявки на изменение позиции сверки
    /// </summary>
    public partial class RoAgentBalanceDetailChangeRequest
    {
        public RoAgentBalanceDetailChangeRequest()
        {
            RoAgentBalanceDetailChangeRequestComments = new HashSet<RoAgentBalanceDetailChangeRequestComment>();
            RoAgentBalanceDetailChangeRequestSteps = new HashSet<RoAgentBalanceDetailChangeRequestStep>();
        }

        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int BalanceDetailChangeRequestId { get; set; }
        /// <summary>
        /// Позиция в сверке, по которой пришло заявление на изменение
        /// </summary>
        public int BalanceDetailId { get; set; }
        /// <summary>
        /// Цена, указанная в сверке
        /// </summary>
        public decimal StartPrice { get; set; }
        /// <summary>
        /// Цена, которую предлагает Партнер или ЦП
        /// </summary>
        public decimal? RequestPrice { get; set; }
        /// <summary>
        /// Цена, утверждённая Вендором
        /// </summary>
        public decimal? FinalPrice { get; set; }
        /// <summary>
        /// Флаг запроса на удаление позиции
        /// </summary>
        public bool ToDelete { get; set; }
        /// <summary>
        /// Скидка
        /// </summary>
        public int? DiscountId { get; set; }
        /// <summary>
        /// Пользователь, подавший заявку на изменение позиции
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Время последнего обновления заявки
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// Время создания заявки
        /// </summary>
        public DateTime CreationTime { get; set; }

        public virtual RoAgentBalanceDetail BalanceDetail { get; set; } = null!;
        public virtual RoDiscount? Discount { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser User { get; set; } = null!;
        public virtual ICollection<RoAgentBalanceDetailChangeRequestComment> RoAgentBalanceDetailChangeRequestComments { get; set; }
        public virtual ICollection<RoAgentBalanceDetailChangeRequestStep> RoAgentBalanceDetailChangeRequestSteps { get; set; }
    }
}
