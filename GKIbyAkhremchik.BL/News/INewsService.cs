using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GKIbyAkhremchik.BL.News
{
    //interface as a plan for the class
    public interface INewsService
    {
        //get all the news and events
        IEnumerable<NewsModel> GetAll(string nNews);
        IEnumerable<NewsEventModel> GetEvent();

        //take item by id
        NewsModel GetNewsSchoolById(int id, string nameDepart);
        void UpdateNews(NewsModel update, string nameDepart);

        NewsArt GetNewsArtById(int id);
        void UpdateNews(NewsArt update);
        NewsMusical GetNewsMusicalById(int id);
        void UpdateNews(NewsMusical update);
        NewsEvent GetNewsEventById(int id);
        void UpdateNews(NewsEvent update);

        //add and delete new by ID
        void AddNews(NewsModel insert, string nameDepart);
        void AddEvent(NewsEventView insert);
        void DeleteNews(int id, string nameDepart);

        //create a folder for photos
        string PathCreate(NewsModel newsmodel, HttpPostedFileBase upload, string nameDepart);
        //check the path to the photos
        string Path(NewsModel newsmodel);

        //save changes or new news in the database
        void Save();
    }
}
