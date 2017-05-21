using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Gallery
{
    public class AlbumPhotoModel
    {
        public int PhotosId { get; set; }
        public string Name { get; set; }
        public string url1 { get; set; }

        public virtual ICollection<GalleryPhotoModel> GalleryPhotoes { get; set; }
    }
}
