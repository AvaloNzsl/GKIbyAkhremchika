using GKIbyAkhremchik.ViewModel.Gallery;
using System;
using System.ComponentModel.DataAnnotations;

namespace GKIbyAkhremchik.ViewModel.GalleryViewModel
{
    public class GalleryPhotoView
    {
        public int GalleryPhotoId { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата")]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Фотография для галереи")]
        public string Img { get; set; }
        [Display(Name = "Описание краткое")]
        public string Description { get; set; }
        [Display(Name = "ID Альбома")]
        public int PhotosId { get; set; }

        public virtual AlbumPhotoModel AlbumPhoto { get; set; }
    }
}
