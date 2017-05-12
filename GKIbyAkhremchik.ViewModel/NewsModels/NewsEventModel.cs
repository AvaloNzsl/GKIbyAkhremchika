using GKIbyAkhremchik.ViewModel.Gallery;
using System;
using System.ComponentModel.DataAnnotations;

namespace GKIbyAkhremchik.ViewModel.NewsModels
{
    public class NewsEventModel
    {
        [Display(Name = "ID")]
        public int NewsEventId { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Фото мероприятия")]
        public string Img { get; set; }
        [Display(Name = "Начинается с ")]
        public Nullable<System.DateTime> DateStart { get; set; }
        [Display(Name = "По ")]
        public Nullable<System.DateTime> DateFinish { get; set; }
        [Display(Name = "Описание мероприятия")]
        public string FullText { get; set; }

        public Nullable<int> GalleryPhotoId { get; set; }
        public virtual GalleryPhotoModel GalleryPhoto { get; set; }
        public Nullable<int> GalleryVideoId { get; set; }
        public virtual GalleryVideoModel GalleryVideo { get; set; }
    }
}
