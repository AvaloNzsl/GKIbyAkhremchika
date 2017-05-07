using System;
using System.ComponentModel.DataAnnotations;

namespace GKIbyAkhremchik.ViewModel.NewsModel
{
    public class NewsModel
    {//for Admin Panel to see the View
        [Display(Name = "ID")]
        public int NewsId { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата")]
        public Nullable<DateTime> Date { get; set; }
        [Display(Name = "Фото мероприятия")]
        public string Img_Title { get; set; }
        [Display(Name = "Краткое описание")]
        public string SmallText { get; set; }
        [Display(Name = "Мероприятие")]
        public string FullText { get; set; }
    }
}
