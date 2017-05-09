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

        public IEnumerable<NewsModel> GetAll()
        {
            var news = new List<NewsModel>();
            var newsGet = _contextUnit.SchoolNews.GetAllNews();
            foreach (var n in newsGet)
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
            return news;
        }

        public void AddNews(NewsView insert)
        {
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

        public NewsSchool GetNewsById(int id)
        {
            return _contextUnit.SchoolNews.GetNewsById(id);
        }
        public void UpdateNews(NewsSchool update)
        {
            _contextUnit.SchoolNews.UpdateNews(update);
        }
        public void DeleteNews(int id)
        {
            _contextUnit.SchoolNews.DeleteNews(id);
        }

        public void Save() { _contextUnit.Save(); }
    }
}
