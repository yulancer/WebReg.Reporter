﻿using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица отклоненных заявлений
    /// </summary>
    public partial class RoRejectedRegRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int RejectedRegRequestId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public int? RegRequestTypeId { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string? Inn { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string? Kpp { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// Мобильный
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Электронный адрес
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Нименование
        /// </summary>
        public string? ShortName { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public int StepId { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// Документооборот
        /// </summary>
        public int WorkflowId { get; set; }
        /// <summary>
        /// Тип продукта
        /// </summary>
        public int? ProductTypeId { get; set; }
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public Guid? ProductGuid { get; set; }
        /// <summary>
        /// Заявление
        /// </summary>
        public int? RequestId { get; set; }

        public virtual RoProductType? ProductType { get; set; }
        public virtual RoRegRequestType? RegRequestType { get; set; }
        public virtual RoStep Step { get; set; } = null!;
        public virtual RoWorkflow Workflow { get; set; } = null!;
    }
}
