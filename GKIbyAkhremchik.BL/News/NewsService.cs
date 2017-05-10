using System;
using System.Collections.Generic;
using GKIbyAkhremchik.ViewModel.NewsModel;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using GKIbyAkhremchik.DAL.Context;
using GKIbyAkhremchik.DAL;

namespace GKIbyAkhremchik.BL.News
{
    public class NewsService : INewsService
    {
        private UnitNewsServices _contextUnit;
        public NewsService(UnitNewsServices contextUnit)
        {
            _contextUnit = contextUnit;
        }

        public IEnumerable<NewsModel> GetAll(string nameNews)
        {
            var news = new List<NewsModel>();

            if (nameNews == "school")
            {
                var school = _contextUnit.SchoolNews.GetAllNews();
                foreach (var n in school)
                {
                    news.Add(new NewsModel
                    {
                        NewsId = n.NewsSchoolId,
                        Title = n.Title,
                        Img_Title = n.Img_Title,
                        Date = n.Date,
                        SmallText = n.SmallText,
                        FullText = n.FullText
                    });
                }
            }
            if (nameNews == "art")
            {
                var art = _contextUnit.ArtNews.GetAllNews();
                foreach (var n in art)
                {
                    news.Add(new NewsModel
                    {
                        NewsId = n.NewsArtId,
                        Title = n.Title,
                        Img_Title = n.Img_Title,
                        Date = n.Date,
                        SmallText = n.SmallText,
                        FullText = n.FullText
                    });
                }
            }
            if (nameNews == "musical")
            {
                var musical = _contextUnit.MusicNews.GetAllNews();
                foreach (var n in musical)
                {
                    news.Add(new NewsModel
                    {
                        NewsId = n.NewsMusicalId,
                        Title = n.Title,
                        Img_Title = n.Img_Title,
                        Date = n.Date,
                        SmallText = n.SmallText,
                        FullText = n.FullText
                    });
                }
            }
            //if (nameNews == "event")
            //{
            //    var nEvent = _contextUnit.EventNews.GetAllNews();
            //    foreach (var n in nEvent)
            //    {
            //        news.Add(new NewsModel
            //        {
            //            NewsId = n.NewsEventId,
            //            Title = n.Title,
            //            Img_Title = n.Img,
            //            Date = n.DateStart,
            //            SmallText = n.Description,
            //            FullText = n.FullText
            //        });
            //    }
            //}

            //else HttpNotFount();
            return news;
        }

        public void AddNews(NewsView insert, string nameDepart)
        {
            if (nameDepart == "school") {
                NewsSchool news = new NewsSchool
                {
                    Title = insert.Title,
                    Img_Title = insert.Img_Title,
                    Date = insert.Date,
                    SmallText = insert.SmallText,
                    FullText = insert.FullText
                };
                _contextUnit.SchoolNews.AddNews(news);
            }
        }

        public NewsSchool GetNewsSchoolById(int id)
        {
            return _contextUnit.SchoolNews.GetNewsById(id);
        }
        public void UpdateNews(NewsSchool update)
        {
            _contextUnit.SchoolNews.UpdateNews(update);
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
        }

        public void Save() { _contextUnit.Save(); }


    }
}
