using System;

namespace GKIbyAkhremchik.DAL.NewsTable
{
    public partial class ArtNews
    {
        public int NewsArtId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Img_Title { get; set; }
        public string SmallText { get; set; }
        public string FullText { get; set; }
    }
}
