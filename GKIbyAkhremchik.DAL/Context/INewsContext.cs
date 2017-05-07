using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.DAL.Context
{
    public interface INewsContext
    {
        IEnumerable<NewsSchool> GetAllNewsSchool();
        void AddNews(NewsSchool news);
        void DeleteNews(int id);
    }
}
