using GKIbyAkhremchik.ViewModel.NewsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Gallery
{
    public class GalleryVideoModel
    {
        [Display(Name = "ID")]
        public int GalleryVideoId { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Фотография для галереи")]
        public string Img { get; set; }
        [Display(Name = "Краткое описание")]
        public string Description { get; set; }
        [Display(Name = "Ссылка на видео")]
        public string Url { get; set; }

        public virtual ICollection<NewsModel> NewsModels { get; set; }//include art musical school properties
        public virtual ICollection<NewsEventModel> NewsEventModels { get; set; }
    }
}
