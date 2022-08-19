using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class RoKeyPermission
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int KeyPermissionId { get; set; }
        /// <summary>
        /// Ключ владельца ЭП
        /// </summary>
        public int PersonKeyId { get; set; }
        /// <summary>
        /// Разрешение
        /// </summary>
        public int PermissionId { get; set; }

        public virtual RoPermission Permission { get; set; } = null!;
        public virtual RoProductPersonKey PersonKey { get; set; } = null!;
    }
}
