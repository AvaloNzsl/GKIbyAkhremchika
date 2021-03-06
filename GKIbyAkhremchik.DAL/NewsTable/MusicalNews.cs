﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.DAL.NewsTable
{
    public partial class MusicalNews
    {
        public int NewsMusicalId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Img_Title { get; set; }
        public string SmallText { get; set; }
        public string FullText { get; set; }
        public Nullable<int> GalleryPhotoId { get; set; }
        public Nullable<int> GalleryVideoId { get; set; }

        public virtual GalleryVideo GalleryVideo { get; set; }
        public virtual GalleryPhoto GalleryPhoto { get; set; }
    }
}
