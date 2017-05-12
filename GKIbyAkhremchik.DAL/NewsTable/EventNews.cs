using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.DAL.NewsTable
{
    public partial class EventNews
    {
        public int NewsEventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateFinish { get; set; }
        public string FullText { get; set; }
        public Nullable<int> GalleryPhotoId { get; set; }
        public Nullable<int> GalleryVideoId { get; set; }

        public virtual GalleryVideo GalleryVideo { get; set; }
        public virtual GalleryPhoto GalleryPhoto { get; set; }
    }
}
