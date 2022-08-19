using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoOfdPin
    {
        public RoOfdPin()
        {
            RoOfdPinSettings = new HashSet<RoOfdPinSetting>();
            OfdPinTemplates = new HashSet<RoOfdPinTemplate>();
        }

        /// <summary>
        /// Ид.
        /// </summary>
        public int PinId { get; set; }
        /// <summary>
        /// Префикс
        /// </summary>
        public int PrefixId { get; set; }
        /// <summary>
        /// Пин
        /// </summary>
        public string Pin { get; set; } = null!;
        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Счёт
        /// </summary>
        public int? BillId { get; set; }
        /// <summary>
        /// Время активации
        /// </summary>
        public DateTime? ActivationTime { get; set; }
        public int? ContractTariffId { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public int? CommentId { get; set; }
        /// <summary>
        /// Срок действия тарифа
        /// </summary>
        public int? Validity { get; set; }
        /// <summary>
        /// Единица измерения срока действия тарифа
        /// </summary>
        public int? ValidityUnitId { get; set; }
        /// <summary>
        /// Ид. скидки
        /// </summary>
        public int? OfdDiscountId { get; set; }
        /// <summary>
        /// Настройки
        /// </summary>
        public string? ConfigJson { get; set; }
        /// <summary>
        /// Полное значение пин-кода
        /// </summary>
        public string? PinFull { get; set; }
        /// <summary>
        /// Партнёр
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// ЦП
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Дни ожидания
        /// </summary>
        public int? WaitingDays { get; set; }
        /// <summary>
        /// Цена для партнёра
        /// </summary>
        public decimal? AgentPrice { get; set; }
        /// <summary>
        /// Цена для ЦП
        /// </summary>
        public decimal? ScPrice { get; set; }
        /// <summary>
        /// Номенклатура
        /// </summary>
        public string? Article { get; set; }
        /// <summary>
        /// Ид шаблона
        /// </summary>
        public Guid? PinTemplateId { get; set; }
        /// <summary>
        /// Доступность кода активации
        /// </summary>
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string? Inn { get; set; }
        public int? OfdDeviceId { get; set; }
        /// <summary>
        /// Тип пин кода
        /// </summary>
        public int OfdPinTypeId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoSendedBill? Bill { get; set; }
        public virtual RoComment? Comment { get; set; }
        public virtual RoContractTariff? ContractTariff { get; set; }
        public virtual RoOfdDevice? OfdDevice { get; set; }
        public virtual RoOfdDiscount? OfdDiscount { get; set; }
        public virtual RoOfdPinType OfdPinType { get; set; } = null!;
        public virtual RoAgent? Parent { get; set; }
        public virtual RoOfdPinTemplate? PinTemplate { get; set; }
        public virtual RoOfdPrefix Prefix { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual RoUnit? ValidityUnit { get; set; }
        public virtual ICollection<RoOfdPinSetting> RoOfdPinSettings { get; set; }

        public virtual ICollection<RoOfdPinTemplate> OfdPinTemplates { get; set; }
    }
}
