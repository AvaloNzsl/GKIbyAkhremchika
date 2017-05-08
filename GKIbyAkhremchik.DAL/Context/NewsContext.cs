using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Context
{
    public class NewsContext : INewsContext
    {
        private GKIDbContext _contextDbNews;
        public NewsContext()
        {
            _contextDbNews = new GKIDbContext();
        }
        public NewsContext(GKIDbContext contextDbNews)
        {
            _contextDbNews = contextDbNews;
        }

        public IEnumerable<NewsSchool> GetAllNewsSchool()
        {
            return _contextDbNews.SchoolNews.ToList();
        }
        public NewsSchool GetNewsById(int id)
        {
            return _contextDbNews.SchoolNews.Find(id);
        }

        public void AddNews(NewsSchool news)
        {
            _contextDbNews.SchoolNews.Add(news);
        }
        public void UpdateNews(NewsSchool updateN)
        {
            _contextDbNews.Entry(updateN).State = EntityState.Modified;
            _contextDbNews.SaveChanges();
        }
        public void DeleteNews(int id)
        {
            NewsSchool news = _contextDbNews.SchoolNews.Find(id);//first method   
            //second method
            //var news = (from n in _contextDbNews.NewsSchool
            //            where n.NewsSchoolId == id
            //            select n).First();

            if (news != null)
            {
                _contextDbNews.SchoolNews.Remove(news);
            }
        }

        public void Save(){_contextDbNews.SaveChanges();}

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed) { if (disposing) { _contextDbNews.Dispose(); } }
            this.disposed = true;
        }
        public void Dispose() { Dispose(true);GC.SuppressFinalize(this); }
    }
}
