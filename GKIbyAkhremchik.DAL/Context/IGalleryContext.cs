using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.Context
{
    public interface IGalleryContext<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllGallery();
        TEntity GetGalleryById(int id);

        void AddGallery(TEntity insertGallery);
        void UpdateGallery(TEntity updateGallery);
        void DeleteGallery(int id);

        void SaveGallery();
    }
}
