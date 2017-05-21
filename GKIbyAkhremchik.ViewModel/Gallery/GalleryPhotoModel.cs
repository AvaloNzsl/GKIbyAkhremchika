using GKIbyAkhremchik.ViewModel.NewsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GKIbyAkhremchik.ViewModel.Gallery
{
    public class GalleryPhotoModel
    {
        [Display(Name = "ID")]
        public int GalleryPhotoId { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Фотография для галереи")]
        public string Img { get; set; }
        [Display(Name = "Описание краткое")]
        public string Description { get; set; }
        [Display(Name = "ID Альбома")]
        public int PhotosId { get; set; }

        //public virtual AlbumPhotoModel AlbumPhoto { get; set; }
        public virtual ICollection<NewsModel> NewsModels { get; set; }//include art musical school properties
        public virtual ICollection<NewsEventModel> NewsEventModels { get; set; }
    }
}
