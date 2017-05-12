using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.DAL.Gallery
{
    public partial class VideoGallery
    {
        public VideoGallery()
        {
            NewsArts = new HashSet<NewsArt>();
            NewsEvents = new HashSet<NewsEvent>();
            NewsMusicals = new HashSet<NewsMusical>();
            NewsSchools = new HashSet<NewsSchool>();
        }

        public int GalleryVideoId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public virtual ICollection<NewsArt> NewsArts { get; set; }
        public virtual ICollection<NewsEvent> NewsEvents { get; set; }
        public virtual ICollection<NewsMusical> NewsMusicals { get; set; }
        public virtual ICollection<NewsSchool> NewsSchools { get; set; }
    }
}
