using System;
using System.Collections.Generic;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.DAL.UnitService;
using AutoMapper;
using GKIbyAkhremchik.BL.AutoMapperConfiguration;
using System.Web;
using System.IO;

namespace GKIbyAkhremchik.BL.News
{
    public class NewsService : INewsService
    {
        //mapping configuration
        private NewsSchoolMapping _schoolMap = new NewsSchoolMapping();
        private NewsArtMapping _artMap = new NewsArtMapping();
        private NewsMusicalMapping _musicalMap = new NewsMusicalMapping();
        //mapping configuration

        private UnitOfWork _contextUnit;
        public NewsService(UnitOfWork contextUnit)
        {
            _contextUnit = contextUnit;
        }

        public IEnumerable<NewsModel> GetAll(string nameNews)
        {
            var news = new List<NewsModel>();
            if (nameNews == "school")
            {
                _schoolMap.MapConfigDB();
                var school = _contextUnit.SchoolNews.GetAllNews();
                news = Mapper.Map<IEnumerable<NewsSchool>, List<NewsModel>>(school);
            }
            if (nameNews == "art")
            {
                _artMap.MapConfigDB();
                var art = _contextUnit.ArtNews.GetAllNews();
                news = Mapper.Map<IEnumerable<NewsArt>, List<NewsModel>>(art);
            }
            if (nameNews == "musical")
            {
                _musicalMap.MapConfigDB();
                var musical = _contextUnit.MusicNews.GetAllNews();
                news = Mapper.Map<IEnumerable<NewsMusical>, List<NewsModel>>(musical);
            }
            return news;
        }

        public IEnumerable<NewsEventModel> GetEvent()
        {
            var news = new List<NewsEventModel>();
            var nEvent = _contextUnit.EventNews.GetAllNews();
            foreach (var n in nEvent)
            {
                news.Add(new NewsEventModel
                {
                    NewsEventId = n.NewsEventId,
                    Title = n.Title,
                    Img = n.Img,
                    DateStart = n.DateStart,
                    DateFinish = n.DateFinish,
                    Description = n.Description,
                    FullText = n.FullText,
                    GalleryPhotoId = n.GalleryPhotoId,
                    GalleryVideoId = n.GalleryVideoId
                });
            }
            return news;
        }

        public void AddNews(NewsModel insert, string nameDepart)
        {
            if (nameDepart == "school")
            {
                _schoolMap.MapConfigModel();
                var news = Mapper.Map<NewsModel, NewsSchool>(insert);
                _contextUnit.SchoolNews.AddNews(news);
            }
            if (nameDepart == "art")
            {
                _artMap.MapConfigModel();
                var news = Mapper.Map<NewsModel, NewsArt>(insert);
                _contextUnit.ArtNews.AddNews(news);
            }
            if (nameDepart == "musical")
            {
                _musicalMap.MapConfigModel();
                var news = Mapper.Map<NewsModel, NewsMusical>(insert);
                _contextUnit.MusicNews.AddNews(news);
            }
        }
        public void AddEvent(NewsEventView insert)
        {
            NewsEvent news = new NewsEvent
            {
                Title = insert.Title,
                Img = insert.Img,
                DateStart = insert.DateStart,
                DateFinish = insert.DateFinish,
                Description = insert.Description,
                FullText = insert.FullText,
                GalleryPhotoId = insert.GalleryPhotoId,
                GalleryVideoId = insert.GalleryVideoId
            };
            _contextUnit.EventNews.AddNews(news);
        }


        public NewsModel GetNewsSchoolById(int id, string nameDepart)
        {
            NewsModel news = new NewsModel();
            if (nameDepart == "school")
            {
                var school = _contextUnit.SchoolNews.GetNewsById(id);
                _schoolMap.MapConfigDB();
                news = Mapper.Map<NewsSchool, NewsModel>(school);
            }
            return news;
        }
        public void UpdateNews(NewsModel update, string nameDepart)
        {
            if (nameDepart == "school")
            {
                _schoolMap.MapConfigModel();
                var updateNews = Mapper.Map<NewsModel, NewsSchool>(update);
                _contextUnit.SchoolNews.UpdateNews(updateNews);
            }
        }

        public NewsArt GetNewsArtById(int id)
        {
            return _contextUnit.ArtNews.GetNewsById(id);
        }
        public void UpdateNews(NewsArt update)
        {
            _contextUnit.ArtNews.UpdateNews(update);
        }

        public NewsMusical GetNewsMusicalById(int id)
        {
            return _contextUnit.MusicNews.GetNewsById(id);
        }
        public void UpdateNews(NewsMusical update)
        {
            _contextUnit.MusicNews.UpdateNews(update);
        }

        public NewsEvent GetNewsEventById(int id)
        {
            return _contextUnit.EventNews.GetNewsById(id);
        }
        public void UpdateNews(NewsEvent update)
        {
            _contextUnit.EventNews.UpdateNews(update);
        }

        public void DeleteNews(int id, string nameDepart)
        {
            if (nameDepart == "school") _contextUnit.SchoolNews.DeleteNews(id);
            if (nameDepart == "art") _contextUnit.ArtNews.DeleteNews(id);
            if (nameDepart == "musical") _contextUnit.MusicNews.DeleteNews(id);
            if (nameDepart == "event") _contextUnit.EventNews.DeleteNews(id);
        }


        public string PathCreate(NewsModel newsmodel, HttpPostedFileBase upload, string nameDepart)
        {
            string personalFolder = newsmodel.Date.ToString().Substring(0, 10) + "." +
            newsmodel.Title.Substring(0, 8).Replace(' ', '_');
            return "~/images/" + nameDepart + "Depart/" + personalFolder + "/";
        }
        public string Path(NewsModel newsmodel) {
            return newsmodel.Date.ToString().Substring(0, 10) + "." +
            newsmodel.Title.Substring(0, 8).Replace(' ', '_');
        }
        public void Save() { _contextUnit.Save(); }
    }
}
