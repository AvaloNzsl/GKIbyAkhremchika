using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.DAL.Context
{
    public interface INewsContext : IDisposable
    { 
        IEnumerable<NewsSchool> GetAllNewsSchool();
        NewsSchool GetNewsById(int id);

        void AddNews(NewsSchool addN);
        void UpdateNews(NewsSchool updateN);
        void DeleteNews(int id);

        void Save();
    }
}
