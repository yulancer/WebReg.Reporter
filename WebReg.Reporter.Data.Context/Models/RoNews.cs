using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    /// <summary>
    /// Таблица новостей
    /// </summary>
    public partial class RoNews
    {
        public RoNews()
        {
            InverseParent = new HashSet<RoNews>();
            RoNewsBrowsings = new HashSet<RoNewsBrowsing>();
            RoNewsFiles = new HashSet<RoNewsFile>();
            RoNewsReviews = new HashSet<RoNewsReview>();
            RoNewsSettings = new HashSet<RoNewsSetting>();
            RoNewsVisibilities = new HashSet<RoNewsVisibility>();
            Tags = new HashSet<RoTag>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int NewsId { get; set; }
        /// <summary>
        /// Тема
        /// </summary>
        public string Topic { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string? Summary { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Содержание
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Тип видимости
        /// </summary>
        public int VisibilityTypeId { get; set; }
        /// <summary>
        /// Отображать поле ввода отзыва
        /// </summary>
        public bool? ShowReview { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public int? ImageId { get; set; }
        /// <summary>
        /// Узел родитель
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTime? OffTime { get; set; }

        public virtual RoNews? Parent { get; set; }
        public virtual RoUser? User { get; set; }
        public virtual RoVisibilityType VisibilityType { get; set; } = null!;
        public virtual ICollection<RoNews> InverseParent { get; set; }
        public virtual ICollection<RoNewsBrowsing> RoNewsBrowsings { get; set; }
        public virtual ICollection<RoNewsFile> RoNewsFiles { get; set; }
        public virtual ICollection<RoNewsReview> RoNewsReviews { get; set; }
        public virtual ICollection<RoNewsSetting> RoNewsSettings { get; set; }
        public virtual ICollection<RoNewsVisibility> RoNewsVisibilities { get; set; }

        public virtual ICollection<RoTag> Tags { get; set; }
    }
}
