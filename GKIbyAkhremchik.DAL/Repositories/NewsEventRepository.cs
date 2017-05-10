using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class NewsEventRepository : INewsContext<NewsEvent>
    {
        internal GKIDbContext _contextDbNews;
        public NewsEventRepository(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public IEnumerable<NewsEvent> GetAllNews()
        {
            return _contextDbNews.EvemtNews;
        }

        public NewsEvent GetNewsById(int id)
        {
            return _contextDbNews.EvemtNews.Find(id);
        }

        public void AddNews(NewsEvent insertNews)
        {
            _contextDbNews.EvemtNews.Add(insertNews);
        }

        public void UpdateNews(NewsEvent updateNews)
        {
            _contextDbNews.Entry(updateNews).State = EntityState.Modified;
        }

        public void DeleteNews(int id)
        {
            NewsEvent news = _contextDbNews.EvemtNews.Find(id);
            if(news != null) {
                _contextDbNews.EvemtNews.Remove(news);
            }
        }

        public void Save()
        {
            _contextDbNews.SaveChanges();
        }
    }
}
