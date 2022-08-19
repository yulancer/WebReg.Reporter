using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица ссылок (URI) на списки анулированных сертификатов
    /// </summary>
    public partial class RoCrlLink
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int CrlLinkId { get; set; }
        /// <summary>
        /// Список
        /// </summary>
        public int CrlId { get; set; }
        /// <summary>
        /// Ссылка
        /// </summary>
        public string Link { get; set; } = null!;

        public virtual RoCrl Crl { get; set; } = null!;
    }
}
