using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GKIbyAkhremchik.BL.News
{
    public interface INewsService
    {
        IEnumerable<NewsModel> GetAll(string nNews);
        IEnumerable<NewsEventModel> GetEvent();

        NewsModel GetNewsSchoolById(int id, string nameDepart);
        void UpdateNews(NewsModel update, string nameDepart);

        NewsArt GetNewsArtById(int id);
        void UpdateNews(NewsArt update);
        NewsMusical GetNewsMusicalById(int id);
        void UpdateNews(NewsMusical update);
        NewsEvent GetNewsEventById(int id);
        void UpdateNews(NewsEvent update);

        void AddNews(NewsModel insert, string nameDepart);
        void AddEvent(NewsEventView insert);
        void DeleteNews(int id, string nameDepart);

        string PathCreate(NewsModel newsmodel, HttpPostedFileBase upload, string nameDepart);
        string Path(NewsModel newsmodel);
        void Save();
    }
}
