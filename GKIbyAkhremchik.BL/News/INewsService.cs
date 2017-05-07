using GKIbyAkhremchik.ViewModel.NewsModel;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Collections.Generic;

namespace GKIbyAkhremchik.BL.News
{
    public interface INewsService
    {
        IEnumerable<NewsModel> GetAll();
        void AddNews(NewsView addNews);
        void DeleteNews(int id);
    }
}
