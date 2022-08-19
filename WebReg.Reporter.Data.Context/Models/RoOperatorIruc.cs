using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица операторов ИРУЦ
    /// </summary>
    public partial class RoOperatorIruc
    {
        public RoOperatorIruc()
        {
            RoMercuryMessengers = new HashSet<RoMercuryMessenger>();
            RoOffices = new HashSet<RoOffice>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int OperatorIrucId { get; set; }
        /// <summary>
        /// Сертификат
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Партнер
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string OperatorIrucName { get; set; } = null!;
        /// <summary>
        /// Логин
        /// </summary>
        public string? IrucLogin { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string? IrucPassword { get; set; }
        /// <summary>
        /// СОС
        /// </summary>
        public int? SosId { get; set; }
        /// <summary>
        /// ДУЦ
        /// </summary>
        public int? DucId { get; set; }

        public virtual RoAgent Agent { get; set; } = null!;
        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoCa? Duc { get; set; }
        public virtual RoSo? Sos { get; set; }
        public virtual ICollection<RoMercuryMessenger> RoMercuryMessengers { get; set; }
        public virtual ICollection<RoOffice> RoOffices { get; set; }
    }
}
