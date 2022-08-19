using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица центров регистрации
    /// </summary>
    public partial class RoRa
    {
        public RoRa()
        {
            RoRaSteps = new HashSet<RoRaStep>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RaId { get; set; }
        /// <summary>
        /// Центр сертификации
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string RaName { get; set; } = null!;
        /// <summary>
        /// Маска имени файла c {id}
        /// </summary>
        public string FileMask { get; set; } = null!;
        /// <summary>
        /// Время последней отправки
        /// </summary>
        public DateTime? LastSending { get; set; }
        /// <summary>
        /// Флаг деловой почты
        /// </summary>
        public bool? Wmail { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string? Host { get; set; }
        /// <summary>
        /// Порт
        /// </summary>
        public int? Port { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoStep Step { get; set; } = null!;
        public virtual ICollection<RoRaStep> RoRaSteps { get; set; }
    }
}
