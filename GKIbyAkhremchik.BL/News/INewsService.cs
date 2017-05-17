using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.BL.News
{
    public interface INewsService
    {
        IEnumerable<NewsModel> GetAll(string nNews);
        IEnumerable<NewsEventModel> GetEvent();

        NewsSchool GetNewsSchoolById(int id);
        void UpdateNews(NewsSchool update);
        NewsArt GetNewsArtById(int id);
        void UpdateNews(NewsArt update);
        NewsMusical GetNewsMusicalById(int id);
        void UpdateNews(NewsMusical update);
        NewsEvent GetNewsEventById(int id);
        void UpdateNews(NewsEvent update);

        void AddNews(NewsView insert, string nameDepart);
        void AddEvent(NewsEventView insert);
        void DeleteNews(int id, string nameDepart);

        void Save();

        NewsModel GetNewsSchoolByIdWithModel(int id);
        void UpdateNewsWithModel(NewsModel update);
    }
}
