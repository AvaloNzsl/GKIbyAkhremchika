using GKIbyAkhremchik.ViewModel.Gallery;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.NewsViewModel
{
    public class NewsView
    {//for Create in the Admin Panel and to see in News Blog
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
