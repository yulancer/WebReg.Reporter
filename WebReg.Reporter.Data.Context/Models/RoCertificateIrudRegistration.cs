using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица состояний регистрации сертификатов в ИРУД
    /// </summary>
    public partial class RoCertificateIrudRegistration
    {
        /// <summary>
        /// Идентификатор регистрации сертификата
        /// </summary>
        public int CertificateRegistrationId { get; set; }
        /// <summary>
        /// Идентификатор сертификата
        /// </summary>
        public int CertificateId { get; set; }
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Идентификатор спецоператора
        /// </summary>
        public int SosId { get; set; }
        /// <summary>
        /// Идентификатор состояния сертификата в ИРУД
        /// </summary>
        public int CertificateStateId { get; set; }
        /// <summary>
        /// Идентификатор статуса процесса регистрации сертификата
        /// </summary>
        public int CertificateRegistrationStepId { get; set; }
        /// <summary>
        /// Время регистрации сертификата
        /// </summary>
        public DateTime? RegistrationTime { get; set; }

        public virtual RoCertificate Certificate { get; set; } = null!;
        public virtual RoStep CertificateRegistrationStep { get; set; } = null!;
        public virtual RoStep CertificateState { get; set; } = null!;
        public virtual RoProduct Product { get; set; } = null!;
        public virtual RoSo Sos { get; set; } = null!;
    }
}
