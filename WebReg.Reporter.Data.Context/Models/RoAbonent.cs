using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица абонентов
    /// </summary>
    public partial class RoAbonent
    {
        public RoAbonent()
        {
            InverseCompanyGroup = new HashSet<RoAbonent>();
            RoAbonentPeople = new HashSet<RoAbonentPerson>();
            RoAgentBalanceDetailAbonents = new HashSet<RoAgentBalanceDetail>();
            RoAgentBalanceDetailAccrRepresents = new HashSet<RoAgentBalanceDetail>();
            RoAgentBalanceDetailCompanyGroups = new HashSet<RoAgentBalanceDetail>();
            RoAgents = new HashSet<RoAgent>();
            RoAstralWorkflowClients = new HashSet<RoAstralWorkflowClient>();
            RoCompanyGroups = new HashSet<RoCompanyGroup>();
            RoContracts = new HashSet<RoContract>();
            RoDocs = new HashSet<RoDoc>();
            RoProductAbonents = new HashSet<RoProduct>();
            RoProductAccrRepresentNavigations = new HashSet<RoProduct>();
            RoProductDocs = new HashSet<RoProductDoc>();
            RoProlongationShortData = new HashSet<RoProlongationShortDatum>();
            RoProxyAgents = new HashSet<RoProxyAgent>();
            RoRegRequests = new HashSet<RoRegRequest>();
            RoSendedBills = new HashSet<RoSendedBill>();
            CompanyGroups = new HashSet<RoCompanyGroup>();
        }

        /// <summary>
        /// Код
        /// </summary>
        public int AbonentId { get; set; }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AbonentTypeId { get; set; }
        /// <summary>
        /// Краткое наименование
        /// </summary>
        public string ShortName { get; set; } = null!;
        /// <summary>
        /// Полное наименование
        /// </summary>
        public string? FullName { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string Inn { get; set; } = null!;
        /// <summary>
        /// КПП
        /// </summary>
        public string Kpp { get; set; } = null!;
        /// <summary>
        /// ОГРН
        /// </summary>
        public string? Ogrn { get; set; }
        /// <summary>
        /// Рег. номер ПФР
        /// </summary>
        public string? RnsPfr { get; set; }
        /// <summary>
        /// Рег. номер ФСС
        /// </summary>
        public string? RnsFss { get; set; }
        /// <summary>
        /// Код подразделения ФСС
        /// </summary>
        public string? KpFss { get; set; }
        /// <summary>
        /// Юридический адрес
        /// </summary>
        public int? PostalAddressId { get; set; }
        /// <summary>
        /// Фактический адрес
        /// </summary>
        public int? LocationAddressId { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Факс
        /// </summary>
        public string? Fax { get; set; }
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Эл. почта
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Офис
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// ОКОПФ
        /// </summary>
        public int? OkopfId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// Рег. номер ПФР работодателя
        /// </summary>
        public string? StRnsPfr { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string? AbonentLogin { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string? AbonentPassword { get; set; }
        /// <summary>
        /// Контакты
        /// </summary>
        public string? ContactPeople { get; set; }
        /// <summary>
        /// Головной абонент
        /// </summary>
        public int? CompanyGroupId { get; set; }
        /// <summary>
        /// Необработанные данные почтового адреса
        /// </summary>
        public string? RawPostalAddress { get; set; }
        /// <summary>
        /// Необработанные данные фактического адреса
        /// </summary>
        public string? RawLocationAddress { get; set; }
        /// <summary>
        /// Необработанные данные контактов
        /// </summary>
        public string? RawContacts { get; set; }
        /// <summary>
        /// Расчетный счет
        /// </summary>
        public string? PaymentAccount { get; set; }
        /// <summary>
        /// Наименование банка
        /// </summary>
        public string? BankName { get; set; }
        /// <summary>
        /// БИК
        /// </summary>
        public string? Bic { get; set; }
        /// <summary>
        /// Корреспондентский счёт
        /// </summary>
        public string? CorrespondentAccount { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// Лицевой счет
        /// </summary>
        public string? PersonalAccount { get; set; }
        /// <summary>
        /// Ид. региона
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Ид. гуид
        /// </summary>
        public Guid AbonentGuid { get; set; }
        /// <summary>
        /// Код подчиненности ФСС
        /// </summary>
        public string? EmplParentNo { get; set; }
        /// <summary>
        /// Рег. номер ФСС обособленного подразделения
        /// </summary>
        public string? RnsFssSub { get; set; }

        public virtual RoAbonentType AbonentType { get; set; } = null!;
        public virtual RoAbonent? CompanyGroup { get; set; }
        public virtual RoAddr? LocationAddress { get; set; }
        public virtual RoOffice Office { get; set; } = null!;
        public virtual RoOkopf? Okopf { get; set; }
        public virtual RoAddr? PostalAddress { get; set; }
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoUser? User { get; set; }
        public virtual RoStatisticProvider? RoStatisticProvider { get; set; }
        public virtual ICollection<RoAbonent> InverseCompanyGroup { get; set; }
        public virtual ICollection<RoAbonentPerson> RoAbonentPeople { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetailAbonents { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetailAccrRepresents { get; set; }
        public virtual ICollection<RoAgentBalanceDetail> RoAgentBalanceDetailCompanyGroups { get; set; }
        public virtual ICollection<RoAgent> RoAgents { get; set; }
        public virtual ICollection<RoAstralWorkflowClient> RoAstralWorkflowClients { get; set; }
        public virtual ICollection<RoCompanyGroup> RoCompanyGroups { get; set; }
        public virtual ICollection<RoContract> RoContracts { get; set; }
        public virtual ICollection<RoDoc> RoDocs { get; set; }
        public virtual ICollection<RoProduct> RoProductAbonents { get; set; }
        public virtual ICollection<RoProduct> RoProductAccrRepresentNavigations { get; set; }
        public virtual ICollection<RoProductDoc> RoProductDocs { get; set; }
        public virtual ICollection<RoProlongationShortDatum> RoProlongationShortData { get; set; }
        public virtual ICollection<RoProxyAgent> RoProxyAgents { get; set; }
        public virtual ICollection<RoRegRequest> RoRegRequests { get; set; }
        public virtual ICollection<RoSendedBill> RoSendedBills { get; set; }

        public virtual ICollection<RoCompanyGroup> CompanyGroups { get; set; }
    }
}
