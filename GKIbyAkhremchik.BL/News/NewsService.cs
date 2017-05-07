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
        private INewsContext _contextNews;
        public NewsService(INewsContext contextNews)
        {
            _contextNews = contextNews;
        }

        public void AddNews(NewsView addNews)
        {
            NewsSchool news = new NewsSchool {
                Title = addNews.Title, Img_Title = addNews.Img_Title, Date = addNews.Date,
                SmallText = addNews.SmallText, FullText = addNews.FullText
            };
            _contextNews.AddNews(news);
        }

        public void DeleteNews(int id)
        {
            _contextNews.DeleteNews(id);
        }

        public IEnumerable<NewsModel> GetAll()
        {
            var news = new List<NewsModel>();
            var newsGet = _contextNews.GetAllNewsSchool();
            foreach (var n in newsGet)
            {
                news.Add(new NewsModel { NewsId = n.NewsSchoolId, Title = n.Title,
                    Img_Title = n.Img_Title, Date = n.Date, SmallText = n.SmallText, FullText = n.FullText
                });
            }
            return news;
        }
    }
}
