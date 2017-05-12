using System;
using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.Gallery
{
    public partial class PhotoGallery
    {
        public PhotoGallery()
        {
            NewsArts = new HashSet<NewsArt>();
            NewsEvents = new HashSet<NewsEvent>();
            NewsMusicals = new HashSet<NewsMusical>();
            NewsSchools = new HashSet<NewsSchool>();
        }

        public int GalleryPhotoId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public int PhotosId { get; set; }

        public virtual AlbumPhoto AlbumPhoto { get; set; }
        public virtual ICollection<NewsArt> NewsArts { get; set; }
        public virtual ICollection<NewsEvent> NewsEvents { get; set; }
        public virtual ICollection<NewsMusical> NewsMusicals { get; set; }
        public virtual ICollection<NewsSchool> NewsSchools { get; set; }
    }
}
