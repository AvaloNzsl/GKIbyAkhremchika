using GKIbyAkhremchik.DAL.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.Repositories
{
    public class NewsSchoolRepository : INewsContext<NewsSchool>
    {
        internal GKIDbContext _contextDbNews;
        public NewsSchoolRepository(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public IEnumerable<NewsSchool> GetAllNews()
        {
            return _contextDbNews.SchoolNews;
        }

        public NewsSchool GetNewsById(int id)
        {
            return _contextDbNews.SchoolNews.Find(id);
        }

        public void AddNews(NewsSchool insertNews)
        {
            _contextDbNews.SchoolNews.Add(insertNews);
        }

        public void UpdateNews(NewsSchool updateNews)
        {
            _contextDbNews.Entry(updateNews).State = EntityState.Modified;
        }

        public void DeleteNews(int id)
        {
            NewsSchool news = _contextDbNews.SchoolNews.Find(id);
            if(news != null) {
                _contextDbNews.SchoolNews.Remove(news);
            }
        }

        public void Save()
        {
            _contextDbNews.SaveChanges();
        }
    }
}
