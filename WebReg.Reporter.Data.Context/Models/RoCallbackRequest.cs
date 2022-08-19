using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица запросов обратных звонков в call-center
    /// </summary>
    public partial class RoCallbackRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RequestId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; } = null!;
        /// <summary>
        /// Имя абонента
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// ИНН абонента
        /// </summary>
        public string? Inn { get; set; }
        /// <summary>
        /// Идентификатор диагностического отчета
        /// </summary>
        public string? DiagReportId { get; set; }
        /// <summary>
        /// Номер задачи от call-center
        /// </summary>
        public int? CalloutId { get; set; }
        /// <summary>
        /// Тип запроса на обратный звонок
        /// </summary>
        public int CallbackRequestTypeId { get; set; }

        public virtual RoCallbackRequestType CallbackRequestType { get; set; } = null!;
    }
}
