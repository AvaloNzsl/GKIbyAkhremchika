using GKIbyAkhremchik.ViewModel.Gallery;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.NewsViewModel
{
    public class NewsEventView
    {
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Фото")]
        public string Img { get; set; }
        [Display(Name = "Начало")]
        public DateTime  DateStart { get; set; }
        [Display(Name = "Окончание")]
        public DateTime  DateFinish { get; set; }
        [Display(Name = "Мероприятие")]
        public string FullText { get; set; }
        public Nullable<int> GalleryPhotoId { get; set; }
        public virtual GalleryPhotoModel GalleryPhoto { get; set; }
        public Nullable<int> GalleryVideoId { get; set; }
        public virtual GalleryVideoModel GalleryVideo { get; set; }
    }
}
