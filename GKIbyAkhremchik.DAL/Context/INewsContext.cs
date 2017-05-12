using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Context
{
    public interface INewsContext<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetSchool();

        IEnumerable<TEntity> GetAllNews();
        TEntity GetNewsById(int id);

        void AddNews(TEntity insertNews);
        void UpdateNews(TEntity updateNews);
        void DeleteNews(int id);

        void Save();
    }
}
