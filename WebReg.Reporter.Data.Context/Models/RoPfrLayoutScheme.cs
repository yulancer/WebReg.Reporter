using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица параметров документов для отправки в ПФР
    /// </summary>
    public partial class RoPfrLayoutScheme
    {
        /// <summary>
        /// Регион
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Формат файлов, которые можно прикрепить к создаваемому документу
        /// </summary>
        public string? AttachMask { get; set; }
        /// <summary>
        /// Максимально возможный размер каждого вложения (в мб)
        /// </summary>
        public int? AttachLimitFile { get; set; }
        /// <summary>
        /// Максимально возможный суммарный размер вложения (в мб)
        /// </summary>
        public int? AttachLimit { get; set; }
        /// <summary>
        /// Идентификатор типа документа
        /// </summary>
        public int PfrSchemeTypeId { get; set; }
        /// <summary>
        /// Маска имени файла архива макетов ПД
        /// </summary>
        public int? Seniority { get; set; }
        /// <summary>
        /// Проверка КС СНИЛС
        /// </summary>
        public int? FullSnils { get; set; }
        /// <summary>
        /// Возможность зиповать вложения
        /// </summary>
        public int? AttachZip { get; set; }
        /// <summary>
        /// Выбор направлений МПД, для отправки писем
        /// </summary>
        public int? Letter { get; set; }
        /// <summary>
        /// Отображение направлений в комбобоксе &quot;Код УПФР по месту назначения пенсии&quot;
        /// </summary>
        public int? LayoutType { get; set; }
        public int FileMaskId { get; set; }
        public int SubjectMaskId { get; set; }

        public virtual RoPfrSchemeFileMask FileMask { get; set; } = null!;
        public virtual RoPfrSchemeType PfrSchemeType { get; set; } = null!;
        public virtual RoRegion Region { get; set; } = null!;
        public virtual RoPfrSchemeSubjectMask SubjectMask { get; set; } = null!;
    }
}
