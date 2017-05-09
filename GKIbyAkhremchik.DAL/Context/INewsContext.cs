using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.DAL.Context
{
    public interface INewsContext<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllNews();
        TEntity GetNewsById(int id);

        void AddNews(TEntity insertNews);
        void UpdateNews(TEntity updateNews);
        void DeleteNews(int id);

        void Save();
    }
}
