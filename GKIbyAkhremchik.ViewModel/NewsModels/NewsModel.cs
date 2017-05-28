using GKIbyAkhremchik.ViewModel.Gallery;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GKIbyAkhremchik.ViewModel.NewsModels
{
    public class NewsModel
    {
        [Display(Name = "ID")]
        public int NewsId { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Фото мероприятия")]
        public string Img_Title { get; set; }
        [Display(Name = "Краткое описание")]
        public string SmallText { get; set; }
        [Display(Name = "Мероприятие")]
        public string FullText { get; set; }

        public Nullable<int> GalleryPhotoId { get; set; }
        public virtual GalleryPhotoModel GalleryPhoto { get; set; }
        public Nullable<int> GalleryVideoId { get; set; }
        public virtual GalleryVideoModel GalleryVideo { get; set; }
    }

}
