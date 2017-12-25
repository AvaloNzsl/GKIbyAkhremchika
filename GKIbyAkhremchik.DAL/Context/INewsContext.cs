using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Context
{
    public interface INewsContext<TEntity> where TEntity : class
    {
        //interface for working with a database and individual repositories
        //TEntity represents the object type of the value specified in the repository
        IQueryable<TEntity> GetSchool();

        //take a list of all the news from the database
        IEnumerable<TEntity> GetAllNews();
        //take news by ID
        TEntity GetNewsById(int id);
        //upload, update, delete news
        void AddNews(TEntity insertNews);
        void UpdateNews(TEntity updateNews);
        void DeleteNews(int id);
        //save changes 
        void Save();
    }
}
