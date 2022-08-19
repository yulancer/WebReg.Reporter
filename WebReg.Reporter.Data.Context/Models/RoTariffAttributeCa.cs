using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица УЦ атрибутов шаблонов тарифа
    /// </summary>
    public partial class RoTariffAttributeCa
    {
        /// <summary>
        /// ИД атрибута тарифа
        /// </summary>
        public int TariffAttributeId { get; set; }
        /// <summary>
        /// ИД УЦ
        /// </summary>
        public int CaId { get; set; }
        /// <summary>
        /// УЦ используется по умолчанию
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// ИД шаблона для УЦ
        /// </summary>
        public int? CaTemplateId { get; set; }
        /// <summary>
        /// ИД УЦ атрибута шаблона тарифа
        /// </summary>
        public int TariffAttributeCaId { get; set; }

        public virtual RoCa Ca { get; set; } = null!;
        public virtual RoCaTemplate? CaTemplate { get; set; }
        public virtual RoTariffAttribute TariffAttribute { get; set; } = null!;
    }
}
