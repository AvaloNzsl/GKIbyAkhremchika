using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModel;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Collections.Generic;

namespace GKIbyAkhremchik.BL.News
{
    public interface INewsService
    {
        IEnumerable<NewsModel> GetAll();
        NewsSchool GetNewsById(int id);

        void AddNews(NewsView insert);
        void UpdateNews(NewsSchool update);
        void DeleteNews(int id);

        void Save();
    }
}
