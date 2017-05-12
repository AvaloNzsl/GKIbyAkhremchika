using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class NewsMusicalRepository : INewsContext<NewsMusical>
    {
        internal GKIDbContext _contextDbNews;
        public NewsMusicalRepository(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public IEnumerable<NewsMusical> GetAllNews()
        {
            return _contextDbNews.MusicalNews;
        }

        public NewsMusical GetNewsById(int id)
        {
            return _contextDbNews.MusicalNews.Find(id);
        }

        public void AddNews(NewsMusical insertNews)
        {
            _contextDbNews.MusicalNews.Add(insertNews);
        }

        public void UpdateNews(NewsMusical updateNews)
        {
            _contextDbNews.Entry(updateNews).State = EntityState.Modified;
        }

        public void DeleteNews(int id)
        {
            NewsMusical news = _contextDbNews.MusicalNews.Find(id);
            if(news != null) {
                _contextDbNews.MusicalNews.Remove(news);
            }
        }

        public void Save()
        {
            _contextDbNews.SaveChanges();
        }

        public IQueryable<NewsMusical> GetSchool()
        {
            throw new NotImplementedException();
        }
    }
}
