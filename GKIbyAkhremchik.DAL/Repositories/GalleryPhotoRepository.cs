using System.Collections.Generic;
using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class GalleryPhotoRepository : IGalleryContext<GalleryPhoto>
    {
        internal GKIDbContext _contextDbGallery;
        public GalleryPhotoRepository(GKIDbContext contextDbGallery)
        {
            _contextDbGallery = contextDbGallery;
        }

        public IEnumerable<GalleryPhoto> GetAllGallery()
        {
            return _contextDbGallery.GalleryPhotoes;
        }

        public GalleryPhoto GetGalleryById(int id)
        {
            return _contextDbGallery.GalleryPhotoes.Find(id);
        }

        public void AddGallery(GalleryPhoto insertGallery)
        {
            _contextDbGallery.GalleryPhotoes.Add(insertGallery);
        }

        public void UpdateGallery(GalleryPhoto updateGallery)
        {
            _contextDbGallery.Entry(updateGallery).State = EntityState.Modified;
        }

        public void DeleteGallery(int id)
        {
            GalleryPhoto gp = _contextDbGallery.GalleryPhotoes.Find(id);
            if(gp != null) {
                _contextDbGallery.GalleryPhotoes.Remove(gp);
            }
        }

        public void SaveGallery()
        {
            _contextDbGallery.SaveChanges();
        }
    }
}
