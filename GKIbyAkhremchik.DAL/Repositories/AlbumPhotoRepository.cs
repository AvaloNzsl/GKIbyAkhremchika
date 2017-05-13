using GKIbyAkhremchik.DAL.Context;
using System.Collections.Generic;
using System.Data.Entity;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class AlbumPhotoRepository : IGalleryContext<AlbumPhoto>
    {
        internal GKIDbContext _contextDbGallery;
        public AlbumPhotoRepository(GKIDbContext contextDbGallery)
        {
            _contextDbGallery = contextDbGallery;
        }

        public IEnumerable<AlbumPhoto> GetAllGallery()
        {
            return _contextDbGallery.AlbumPhotoes;
        }

        public AlbumPhoto GetGalleryById(int id)
        {
            return _contextDbGallery.AlbumPhotoes.Find(id);
        }

        public void AddGallery(AlbumPhoto insertGallery)
        {
            _contextDbGallery.AlbumPhotoes.Add(insertGallery);
        }

        public void UpdateGallery(AlbumPhoto updateGallery)
        {
            _contextDbGallery.Entry(updateGallery).State = EntityState.Modified;
        }

        public void DeleteGallery(int id)
        {
            AlbumPhoto ap = _contextDbGallery.AlbumPhotoes.Find(id);
            if (ap != null)
            {
                _contextDbGallery.AlbumPhotoes.Remove(ap);
            }
        }

        public void SaveGallery()
        {
            _contextDbGallery.SaveChanges();
        }
    }
}
