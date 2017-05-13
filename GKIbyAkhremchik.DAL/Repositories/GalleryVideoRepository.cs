using System.Collections.Generic;
using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class GalleryVideoRepository : IGalleryContext<GalleryVideo>
    {
        internal GKIDbContext _contextDbGallery;
        public GalleryVideoRepository(GKIDbContext contextDbGallery)
        {
            _contextDbGallery = contextDbGallery;
        }

        public IEnumerable<GalleryVideo> GetAllGallery()
        {
            return _contextDbGallery.GalleryVideos;
        }

        public GalleryVideo GetGalleryById(int id)
        {
            return _contextDbGallery.GalleryVideos.Find(id);
        }

        public void AddGallery(GalleryVideo insertGallery)
        {
            _contextDbGallery.GalleryVideos.Add(insertGallery);
        }

        public void UpdateGallery(GalleryVideo updateGallery)
        {
            _contextDbGallery.Entry(updateGallery).State = EntityState.Modified;
        }

        public void DeleteGallery(int id)
        {
            GalleryVideo gv = _contextDbGallery.GalleryVideos.Find(id);
            if (gv != null)
            {
                _contextDbGallery.GalleryVideos.Remove(gv);
            }
        }

        public void SaveGallery()
        {
            _contextDbGallery.SaveChanges();
        }
    }
}
