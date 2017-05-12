using System;
using System.ComponentModel.DataAnnotations;

namespace GKIbyAkhremchik.ViewModel.GalleryViewModel
{
    public class GalleryVideoView
    {
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата")]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Фотография для галереи")]
        public string Img { get; set; }
        [Display(Name = "Краткое описание")]
        public string Description { get; set; }
        [Display(Name = "Ссылка на видео")]
        public string Url { get; set; }
    }
}
