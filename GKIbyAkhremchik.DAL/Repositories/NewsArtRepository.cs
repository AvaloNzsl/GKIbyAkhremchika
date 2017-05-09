using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class NewsArtRepository : INewsContext<NewsArt>
    {
        internal GKIDbContext _contextDbNews;
        public NewsArtRepository(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public IEnumerable<NewsArt> GetAllNews()
        {
            return _contextDbNews.ArtNews;
        }

        public NewsArt GetNewsById(int id)
        {
            return _contextDbNews.ArtNews.Find(id);
        }

        public void AddNews(NewsArt insertNews)
        {
            _contextDbNews.ArtNews.Add(insertNews);
        }

        public void UpdateNews(NewsArt updateNews)
        {
            _contextDbNews.Entry(updateNews).State = EntityState.Modified;
        }

        public void DeleteNews(int id)
        {
            NewsArt news = _contextDbNews.ArtNews.Find(id);
            if(news != null) {
                _contextDbNews.ArtNews.Remove(news);
            }
        }

        public void Save()
        {
            _contextDbNews.SaveChanges();
        }
    }
}
