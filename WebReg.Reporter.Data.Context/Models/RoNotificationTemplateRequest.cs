using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Запросы шаблонов уведомлений
    /// </summary>
    public partial class RoNotificationTemplateRequest
    {
        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Гуид шаблона
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// Тип запроса
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Время приема запроса
        /// </summary>
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Имя шаблона
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string? Mail { get; set; }
        /// <summary>
        /// Окончание действия шаблона
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Запрос на выборку
        /// </summary>
        public string? Query { get; set; }
        /// <summary>
        /// Временной триггер
        /// </summary>
        public int? Trigger { get; set; }
        /// <summary>
        /// Файл запроса
        /// </summary>
        public int FileId { get; set; }

        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoNotificationTemplateRequestType Type { get; set; } = null!;
    }
}
